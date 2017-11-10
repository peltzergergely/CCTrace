
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
//todo: add timestamp - done
//      save to string - done
//      dummy output to the db - done
//      separate target DB based on the information from the carrier DM - done
namespace CCTrace
{
    public partial class Form2 : Form
    {
        Form opener;

        public Form2(Form parentForm) //form opener
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void button3_Click(object sender, EventArgs e) //exitBtn
        {
            this.Close();
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)  //jumps between controls and validates
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                if (ActiveControl == saveBtn)
                    updateLbl(sender, e);
            }
        }

        private bool dataValid() //checks if txtbx values are legit
        {
            if (prodTbx.TextLength > 23 && carrTbx.TextLength > 17 && (carrTbx.Text.Contains("BMW") || carrTbx.Text.Contains("VOLVO")))
                return true;
            else
                return false;
        }

        private void updateLbl(object sender, EventArgs e) //updates label based on info
        {
            if (dataValid())
            {
                outputMsgLbl.ForeColor = System.Drawing.Color.Black;
                //outputMsgLbl.Text = "Az adatok megfelelőek kattints a mentés gombra!";
                saveBtn_Click(sender, e);

            }
            else
            {
                outputMsgLbl.ForeColor = System.Drawing.Color.Red;
                outputMsgLbl.Text = "Nem megfelelő adatok!";
            }
        }

        private string telegramMsg() //data saved in the csv
        {
            return prodTbx.Text + " " + carrTbx.Text + " " + DateTime.Now;
        }

        private void saveToFile() //saves to CSV
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            var cal = dfi.Calendar;
            string filePath = ".\\prod.csv";
            try
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(telegramMsg());
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private string db_connect() //DB connect string
        {
            return String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", "5432", "postgres",
                    "admin", "CCDB");
        }

        private void db_insert(string table) //DB insert
        {
            try
            {
                string connstring = db_connect();
                // Making connection with Npgsql provider
                var conn = new NpgsqlConnection(connstring);
                conn.Open();
                // building SQL query
                var cmd = new NpgsqlCommand("INSERT INTO " + table + " (prod_dm, carr_dm, timestamp) VALUES(:prod_dm, :carr_dm, :timestamp)", conn);
                cmd.Parameters.Add(new NpgsqlParameter("prod_dm", prodTbx.Text));
                cmd.Parameters.Add(new NpgsqlParameter("carr_dm", carrTbx.Text));
                cmd.Parameters.Add(new NpgsqlParameter("timestamp", DateTime.Now));
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
        private string interlock(string table)
        {
            try
            {
                if (table != "Hiba, nem megfelelő adat!")
                {
                    string connstring = db_connect();
                    // Making connection
                    var conn = new NpgsqlConnection(connstring);
                    conn.Open();
                    // building query
                    var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM " + table + " WHERE prod_dm = :prod_dm", conn);
                    cmd.Parameters.Add(new NpgsqlParameter("prod_dm", prodTbx.Text));
                    Int32 countProd = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (countProd == 0)
                    {
                        outputLbl.Text = "Kimenet: ";
                        outputMsgLbl.ForeColor = System.Drawing.Color.Black;
                        return "pass";
                    }

                    //mar van egy talalat akkor megnezem, hogy ezzel az oldallal szerepel-e, ha nem akkor ez BOTTOM OLDAL
                    //meg kell nézni, hogy habár csak egy találat van, az milyen kerettel szerepel.
                    //cmd = new NpgsqlCommand("SELECT carr_dm FROM " + table + " WHERE prod_dm = :prod_dm ", conn);
                    else if (countProd == 1)
                    {
                        conn.Open();
                        cmd = new NpgsqlCommand("SELECT COUNT(*) FROM " + table + " WHERE prod_dm = :prod_dm AND carr_dm = :carr_dm ", conn);
                        cmd.Parameters.Add(new NpgsqlParameter("prod_dm", prodTbx.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("carr_dm", carrTbx.Text));
                        Int32 countProdAndCarr = Convert.ToInt32(cmd.ExecuteScalar());
                        conn.Close();
                        if (countProdAndCarr == 1)
                        {
                            outputLbl.Text = "HIBA!";
                            outputMsgLbl.ForeColor = System.Drawing.Color.Red;
                            outputMsgLbl.Text = "Ennek a terméknek ez a fele már lakkozott!";
                            return "error";
                        }
                        else if (countProdAndCarr == 0) //ha másik keretbe került akkor itt átmegy, ellenőrizni kell, hogy ha nincs találat akkor a keret új?
                        {
                            outputLbl.Text = "Kimenet: ";
                            outputMsgLbl.ForeColor = System.Drawing.Color.Black;
                            return "pass";
                        }
                        else return "error";

                    }
                    else if (countProd == 2)
                    {
                        outputLbl.Text = "HIBA!";
                        outputMsgLbl.ForeColor = System.Drawing.Color.Red;
                        outputMsgLbl.Text = "Ennek a terméknek mindkét oldala lakkozott!";
                        return "error";
                    }
                    else return "error";
                }
                else return "error";
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                return "error";
            }
        }

        private string returnTableName()
        {
            if (carrTbx.Text.Contains("BMW"))
                return "bmw";
            else if (carrTbx.Text.Contains("VOLVO"))
                return "volvo";
            else
                return "Hiba, nem megfelelő adat!";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //check data and upload to database, update CSV, and save to pendrive
            //update window with large label stating if this product have to be removed or proceed to other side
            if (dataValid())
            {
                string interlocking = interlock(returnTableName());
                if (interlocking == "pass")
                {
                    saveToFile();
                    //check if product has been already read
                    db_insert(returnTableName());
                    outputMsgLbl.ForeColor = System.Drawing.Color.Green;
                    outputMsgLbl.Text = "Adatok elmentve!" + "\r\n " + prodTbx.Text + "\r\n" + carrTbx.Text;
                    carrTbx.Text = "";
                    prodTbx.Text = "";
                    prodTbx.Focus();
                    prodTbx.SelectAll();

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
