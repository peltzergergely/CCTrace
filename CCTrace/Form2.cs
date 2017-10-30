
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

//This is the sample product form
//todo: add timestamp
//      save to string
//      dummy output to the db
namespace CCTrace
{
    public partial class Form2 : Form
    {
        Form opener;

        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

            updateLbl();
        }

        private bool dataValid()
        {
            if (prodTbx.TextLength > 0 && carrTbx.TextLength > 0)
                return true;
            else
                return false;
        }

        private void updateLbl()
        {
            if (dataValid())
            {
                outputMsgLbl.Text = telegramMsg();
            }
            else
                outputMsgLbl.Text = "Hiányos adatok!";
        }

        private string telegramMsg()
        {
            return prodTbx.Text + " " + carrTbx.Text + " " + timeStamp();
        }

        private string timeStamp()
        {
            var timeStamp = DateTime.Now;
            return DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
        }

        private string yearAndWeek()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            var cal = dfi.Calendar;
            return DateTime.Now.ToString("yyyy") + cal.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
        }

        private void saveToFile()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            var cal = dfi.Calendar;
            string filePath = "D:\\ExportedData\\prod1_" + yearAndWeek() + ".csv";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(telegramMsg());
            }
        }

        private void db_insert()
        {
            try
            {
                // PostgeSQL-style connection string
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", "5432", "postgres",
                    "admin", "CCDB");
                // Making connection with Npgsql provider
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                // SQL query
                NpgsqlCommand cmd = new NpgsqlCommand("insert into prod1_" + yearAndWeek() + " (prod_DM, carr_DM, timestamp) values(:prod_DM, :carr_DM, :timestamp)", conn);
                cmd.Parameters.Add(new NpgsqlParameter("prod_DM", prodTbx.Text));
                cmd.Parameters.Add(new NpgsqlParameter("carr_DM", carrTbx.Text));
                cmd.Parameters.Add(new NpgsqlParameter("timestamp", timeStamp()));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                //throw;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //check data and upload to database, update CSV, and save to pendrive
            //update window with large label stating if this product have to be removed or proceed to other side
            if (dataValid())
            {
                saveToFile();
                db_insert();
                MessageBox.Show("Data saved (" + telegramMsg() + ")");
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(this);
            frm.Show();
        }
    }
}
