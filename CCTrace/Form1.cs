﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this is just the main menu
namespace CCTrace
{
    public partial class MainScr : Form
    {
        public MainScr()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainScr_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool CloseCancel()
        {
            const string message = "Biztosan be akarod zárni az alkalmazást?";
            const string caption = "Kilépés";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Form2(this);
            frm.Show();
        }

        private void adminPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form3(this);
            frm.Show();
        }

        private void varnBtn_Click(object sender, EventArgs e)
        {
            var frm = new form4(this);
            frm.Show();
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AboutBox1();
            frm.Show();
        }
    }
}
