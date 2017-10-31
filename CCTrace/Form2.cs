﻿
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
        //form opener
        public Form2(Form parentForm) 
        {
            InitializeComponent();
            opener = parentForm;
        }
        //exitBtn
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (prodTbx.TextLength > 0 && carrTbx.TextLength > 0)
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
            return prodTbx.Text + " " + carrTbx.Text + " " + timeStamp();
        }
        //creates the timestamp
        private string timeStamp()
        {
            var timeStamp = DateTime.Now;
            return DateTime.Now.ToString("yyy/MM/dd HH:mm:ss");
        }
        //produces a yearweek
        private string yearAndWeek()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            var cal = dfi.Calendar;
            return DateTime.Now.ToString("yyyy") + cal.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
        }
        //saves to CSV
        private void saveToFile()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            var cal = dfi.Calendar;
            string filePath = "D:\\ExportedData\\prod1.csv";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(telegramMsg());
            }
        }
        //DB connect string
        private string db_connect()
        {
            return String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", "5432", "postgres",
                    "admin", "CCDB");
        }
        //DB insert
        private void db_insert()
        {
            try
            {
                string connstring = db_connect();
                // Making connection with Npgsql provider
                var conn = new NpgsqlConnection(connstring);
                conn.Open();
                // building SQL query
                var cmd = new NpgsqlCommand("INSERT INTO prod1 (prod_DM, carr_DM, timestamp) VALUES(:prod_DM, :carr_DM, :timestamp)", conn);
                cmd.Parameters.Add(new NpgsqlParameter("prod_DM", prodTbx.Text));
                cmd.Parameters.Add(new NpgsqlParameter("carr_DM", carrTbx.Text));
                cmd.Parameters.Add(new NpgsqlParameter("timestamp", timeStamp()));
                cmd.ExecuteNonQuery();
                //closing connection ASAP
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        //making a query with the product and the carrier, and telling the operator what to do!
        //A - product first time in the line TOP - query no result
        //B - product second time but with BOT - query 1 result / no result?
        //C - product goes in again with TOP - ERROR BOT NEEDS TO BE DONE
        //D - product goes in again with BOT - ERROR PRODUCT IS FINISHED
        private string interlock()
        {
            try
            {
                string connstring = db_connect();
                // Making connection
                var conn = new NpgsqlConnection(connstring);
                conn.Open();
                // building query
                var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM prod1 WHERE prod_dm = :prod_dm" , conn);
                cmd.Parameters.Add(new NpgsqlParameter("prod_dm", prodTbx.Text));
                cmd.Parameters.Add(new NpgsqlParameter("carr_DM", carrTbx.Text));
                Int32 count = Convert.ToInt32( cmd.ExecuteScalar());
                conn.Close();
                if (count == 0)
                {
                    outputLbl.Text = "Kimenet: ";
                    outputMsgLbl.ForeColor = System.Drawing.Color.Black;
                    return "pass";
                }
                
                //mar van egy talalat akkor megnezem, hogy ezzel az oldallal szerepel-e, ha nem akkor ez BOTTOM OLDAL
                else if (count == 1)
                {
                    conn.Open();
                    cmd = new NpgsqlCommand("SELECT COUNT(*) FROM prod1 WHERE prod_dm = :prod_dm AND carr_dm = :carr_dm ", conn);
                    cmd.Parameters.Add(new NpgsqlParameter("prod_dm", prodTbx.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("carr_DM", carrTbx.Text));
                    Int32 count2 = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (count2 == 1)
                    {
                        outputLbl.Text = "HIBA!";
                        outputMsgLbl.ForeColor = System.Drawing.Color.Red;
                        outputMsgLbl.Text = "Ennek a terméknek ez a fele már lakkozott!";
                        return "error";
                    }
                    else if (count2 == 0)
                    {
                        outputLbl.Text = "Kimenet: ";
                        outputMsgLbl.ForeColor = System.Drawing.Color.Black;
                        return "pass";
                    }
                    else return "something";

                }else if (count == 2)
                {
                    outputLbl.Text = "HIBA!";
                    outputMsgLbl.ForeColor = System.Drawing.Color.Red;
                    outputMsgLbl.Text = "Ennek a terméknek mindkét oldala lakkozott!";
                    return "error";
                }
                else return "something";
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //check data and upload to database, update CSV, and save to pendrive
            //update window with large label stating if this product have to be removed or proceed to other side
            if (dataValid())
            {
                string interlocking = interlock();
                if (interlocking == "pass")
                {
                    saveToFile();
                    //check if product has been already read
                    db_insert();
                    outputMsgLbl.ForeColor = System.Drawing.Color.Green;
                    outputMsgLbl.Text = "Adatok elmentve!";
                }else if (interlocking == "something")
                {
                    MessageBox.Show("HIBA! kifutott valamelyik else ágra, nem kéne!");
                }
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(this);
            frm.Show();
        }
    }
}
