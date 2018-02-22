using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;

namespace CCTrace
{
    public partial class Form3 : Form
    {
        Form opener;

        public Form3(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
            PopulateComboBox();
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        private void table_select(string query)
        {
            try
            {
                // connstring stored in App.config
                string connstring = ConfigurationManager.ConnectionStrings["CCTrace.Properties.Settings.CCDBConnectionString"].ConnectionString;
                var conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = query;
                // data adapter making request from our connection
                var da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);
                // since it C# DataSet can handle multiple tables, we will select first
                dt = ds.Tables[0];
                // connect grid to DataTable
                dataGridView1.DataSource = dt;
                // since we only showing the result we don't need connection anymore
                conn.Close();
            }
            catch (Exception msg)
            {
                // error handling
                MessageBox.Show(msg.ToString());
                //throw;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            selectCbx.SelectedIndex = 0;
        }

        private void termék1_Click(object sender, EventArgs e)
        {
            table_select("SELECT * FROM bmw");
        }

        private void volvo_Click(object sender, EventArgs e)
        {
            table_select("SELECT * from volvo");
        }

        private void lakk_Click(object sender, EventArgs e)
        {
            table_select("SELECT * FROM lakk");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pwBx.Text.Contains("admin"))
                table_select(queryBx.Text);            
            else
                MessageBox.Show("Ez a művelethez jelszó kell!");
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lekérdezéseket PostgreSQL parancsokkal tudsz indítani." + "\n" + "pl: SELECT * FROM bmw WHERE prod_dm='#azonosító' ");
        }

        private void PopulateComboBox()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("bmw", "BMW");
            dict.Add("volvo", "Volvo");
            dict.Add("lakk", "lakk");

            selectCbx.DataSource = new BindingSource(dict, null);
            selectCbx.DisplayMember = "Value";
            selectCbx.ValueMember = "Key";
        }

        private void select2Btn_Click(object sender, EventArgs e)
        {
            //table_select("SELECT * FROM " + selectCbx.Text + "='" + selectTbx.Text + "'");
            MessageBox.Show(selectCbx.SelectedValue.ToString());
            table_select("SELECT * FROM " + prodCbx.SelectedValue.ToString() + " WHERE workstation = '" + workStationCbx.SelectedValue.ToString() + " ");
            string s = "SELECT * FROM " + prodCbx.SelectedValue.ToString() + " WHERE workstation = '" + workStationCbx.SelectedValue.ToString() + "' ");
            if (xyTextbox.text.length > 0)
            {
                s = s+ " AND prod_dm = '" + xyTextBox.text + "'"
            }
        }
    }
}
