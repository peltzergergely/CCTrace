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

//testing the db connection
//todo:
//      make this form into a searchable admin page
namespace CCTrace
{
    public partial class Form3 : Form
    {
        Form opener;

        public Form3(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
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

        //DB connect string
        private string db_connect()
        {
            return String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", "5432", "postgres",
                    "admin", "CCDB");
        }

        private void table_select(string query)
        {
            try
            {
                // PostgeSQL-style connection string
                string connstring = db_connect();
                // Making connection with Npgsql provider
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                // quite complex sql statement
                string sql = query;
                // data adapter making request from our connection
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
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
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                //throw;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //table_select("SELECT * FROM prod1");
            comboBox1.SelectedIndex = 0;
        }

        private void termék1_Click(object sender, EventArgs e)
        {
            table_select("SELECT * FROM bmw");
        }

        private void lakk_Click(object sender, EventArgs e)
        {
            table_select("SELECT * FROM lakk");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queryBx.Text.Contains("SELECT"))
                table_select(queryBx.Text);            
            else
                MessageBox.Show("csak select utasítás hajtható végre");
        }

        private void volvo_Click(object sender, EventArgs e)
        {
            table_select("SELECT * from volvo");
        }
    }
}
