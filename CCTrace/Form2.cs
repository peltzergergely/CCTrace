
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void prodTbx_KeyUp(object sender, KeyEventArgs e)
        {
            if ( (e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return) )
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
