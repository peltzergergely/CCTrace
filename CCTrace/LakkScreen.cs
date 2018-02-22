using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Globalization;
using System.IO;
using System.Configuration;

namespace CCTrace
{
    public partial class form4 : Form
    {
        Form opener;

        public form4(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        
        private void Control_KeyUp(object sender, KeyEventArgs e) //jumps between controls and validates
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            updateLbl(dataValid());
        }
        
        private bool dataValid() //checks if txtbx is empty
        {
            if (batchTbx.TextLength > 0 && expdateDtp.Value > DateTime.Today)
                return true;
            else
                return false;
        }
        
        private void updateLbl(bool valid) //updates label based on info
        {
            if (valid)
            {
                outputMsgLbl.ForeColor = System.Drawing.Color.Black;
                outputMsgLbl.Text = "Az adatok megfelelőek";
            }
            else
            {
                outputMsgLbl.ForeColor = System.Drawing.Color.Red;
                outputMsgLbl.Text = "Hiba: Batch szám nincs kitöltve, vagy lejárt a lakk szavatossága!";
            }
        }
        
        private string telegramMsg() //data saved in the csv
        {
            return batchTbx.Text + " " + expdateDtp.Text + " " + DateTime.Now;
        }
         
        private void saveToFile() //saves to CSV
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            var cal = dfi.Calendar;
            string filePath = ".\\lakk.csv";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(telegramMsg());
            }
        }

        private void db_insert() //DB insert
        {
            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["CCTrace.Properties.Settings.CCDBConnectionString"].ConnectionString;
                // Making connection with Npgsql provider
                var conn = new NpgsqlConnection(connstring);
                conn.Open();
                // building SQL query
                var cmd = new NpgsqlCommand("INSERT INTO lakk (batch, expdate, timestamp, workstation) VALUES(:batch, :expdate, :timestamp, :workstation)", conn);
                cmd.Parameters.Add(new NpgsqlParameter("batch", batchTbx.Text));
                cmd.Parameters.Add(new NpgsqlParameter("expdate", expdateDtp.Value));
                cmd.Parameters.Add(new NpgsqlParameter("timestamp", DateTime.Now));
                cmd.Parameters.Add(new NpgsqlParameter("workstation", Environment.MachineName));
                cmd.ExecuteNonQuery();
                //closing connection ASAP
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        private void exitBtn_Click(object sender, EventArgs e) //exitbtn
        {
            this.Close();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            expdateDtp.Format = DateTimePickerFormat.Custom;
            expdateDtp.CustomFormat = "MM/yyyy";
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            expdateDtp.Value = startOfMonth;
        }

        private void form4_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
               if (dataValid())
                {
                saveToFile();
                db_insert();
                outputMsgLbl.ForeColor = System.Drawing.Color.Green;
                outputMsgLbl.Text = "Adatok elmentve!";
                MessageBox.Show("Adatok elmentve!");
            }
        }

        private void adminPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(this);
            frm.Show();
        }
    }
}
