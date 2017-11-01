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

        //jumps between controls and validates
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            updateLbl();
        }
        //checks if txtbx is empty
        private bool dataValid()
        {
            if (batchTbx.TextLength > 0 && expdateDtp.Value <= DateTime.Today)
                return true;
            else
                return false;
        }
        //updates label based on info
        private void updateLbl()
        {
            if (dataValid())
            {
                outputMsgLbl.ForeColor = System.Drawing.Color.Black;
                outputMsgLbl.Text = telegramMsg();
            }
            else
            {
                outputMsgLbl.ForeColor = System.Drawing.Color.Red;
                outputMsgLbl.Text = "Hiányos adatok!";
            }
        }
        //data saved in the csv
        private string telegramMsg()
        {
            return batchTbx.Text + " " + expdateDtp.Text + " " + timeStamp();
        }
        //creates the timestamp
        private string timeStamp()
        {
            var timeStamp = DateTime.Now;
            return DateTime.Now.ToString("yyy/MM/dd HH:mm:ss");
        }
        //exitbtn
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            expdateDtp.Format = DateTimePickerFormat.Custom;
            expdateDtp.CustomFormat = "MM/yyyy";
        }

        private void form4_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (dataValid())
            {

            }
        }
    }
}
