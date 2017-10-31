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
            //updateLbl();
        }
        //checks if txtbx is empty
        private bool dataValid()
        {
            if (prodTbx.TextLength > 0 && dateTimePicker1.Value < DateTime.Today)
                return true;
            else
                return false;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
        }

        private void form4_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }
    }
}
