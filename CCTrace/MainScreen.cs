
using Npgsql;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CCTrace
{
    public partial class MainScreen : Form
    {
        Form opener;
        string connetionstringgen2 = "Data Source=10.207.40.200;Initial Catalog=Gen2;Persist Security Info=True;User ID=GEN2;Password=1234";

        private string heatsinkID { get; set; }

        private string mainboardID { get; set; }

        private bool PreChkResult { get; set; } 

        public MainScreen(Form parentForm) //form opener
        {
            InitializeComponent();
            opener = parentForm;
            ReturnCurrentVarnish();
            DailyProduction();
        }

        private void Button3_Click(object sender, EventArgs e) //exitBtn
        {
            this.Close();
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)  //jumps between controls and validates
        {
            if (((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return)) && prodTbx.TextLength > 0)
            {
                
                this.SelectNextControl((Control)sender, true, true, true, true);
                if (ActiveControl == saveBtn)
                    UpdateLbl(sender, e);
            }
        }

        //doing a check if the product is in the database if not then it's not a valid datamatrix
        //if it goes into the catchblock then the result is not valid give an error
        private void HsOrMb()
        {
            if (prodTbx.TextLength == 12) //gen2 heatsink lenght gives the mainboard DM from the heatsink DM
            {
                try
                {
                    SqlConnection cnn = new SqlConnection(connetionstringgen2);
                    cnn.Open();
                    string SQLQuery;
                    SQLQuery = "Select MainBoard_ID from [dbo].[Main] WHERE Heatsink_ID = '" + prodTbx.Text + "'";
                    SqlCommand SQLcmd = new SqlCommand(SQLQuery, cnn);
                    SQLcmd.ExecuteNonQuery();
                    SqlDataAdapter adpm = new SqlDataAdapter(SQLcmd);
                    DataTable dtm = new DataTable();
                    adpm.Fill(dtm);
                    string mbid = dtm.Rows[0]["MainBoard_ID"].ToString();
                    heatsinkID = prodTbx.Text;
                    mainboardID = mbid;
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString());
                }
            }
            else if (prodTbx.TextLength > 23) //gen2 mainboard dm length
            {
                try
                {
                    SqlConnection cnn = new SqlConnection(connetionstringgen2);
                    cnn.Open();
                    string StrQuery1m;
                    StrQuery1m = "Select HeatSink_ID from [dbo].[Main] WHERE MainBoard_ID = '" + prodTbx.Text + "'";
                    SqlCommand objcmdm = new SqlCommand(StrQuery1m, cnn);
                    objcmdm.ExecuteNonQuery();
                    SqlDataAdapter adpm = new SqlDataAdapter(objcmdm);
                    DataTable dtm = new DataTable();
                    adpm.Fill(dtm);
                    string mbid = dtm.Rows[0]["HeatSink_ID"].ToString();
                    heatsinkID = mbid;
                    mainboardID = prodTbx.Text;
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString());
                }
            }
        }

        private bool PreCheck()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(connetionstringgen2);
                cnn.Open();
                string StrQuery1m;
                StrQuery1m = "Select Result from [dbo].[HeatSinkData] WHERE Heatsink_ID = '" + heatsinkID + "' AND Operation_ID = '10615' ORDER BY Date DESC";
                SqlCommand objcmdm = new SqlCommand(StrQuery1m, cnn);
                objcmdm.ExecuteNonQuery();
                SqlDataAdapter adpm = new SqlDataAdapter(objcmdm);
                DataTable dtm = new DataTable();
                adpm.Fill(dtm);
                if (dtm.Rows[0]["Result"].ToString() == "OK")
                {
                    return true;
                }
                else return false;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                return false;
            }
        }

        private bool DataValid() //checks carrier values are legit, decides which table to save to
        {
            if (carrTbx.TextLength > 17 && (carrTbx.Text.Contains("BMW") || carrTbx.Text.Contains("VOLVO")))
                return true;
            else
                return false;
        }

        private void UpdateLbl(object sender, EventArgs e) //updates label based on info
        {
            if (DataValid())
            {
                outputMsgLbl.ForeColor = System.Drawing.Color.Black;
                SaveBtn_Click(sender, e);
            }
            else
            {
                outputMsgLbl.Text = "Nem megfelelő adatok!";
                ErrorBlinking();
            }
        }

        private string TelegramMsg() //data saved in the csv
        {
            return prodTbx.Text + " " + carrTbx.Text + " " + DateTime.Now;
        }

        private void SaveToFile() //saves to CSV
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            var cal = dfi.Calendar;
            string filePath = ".\\prod.csv";
            try
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(TelegramMsg());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Db_insert(string table) //DB insert
        {
            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["CCTrace.Properties.Settings.CCDBConnectionString"].ConnectionString;
                // Making connection with Npgsql provider
                var conn = new NpgsqlConnection(connstring);
                conn.Open();
                // building SQL query
                var cmd = new NpgsqlCommand("INSERT INTO " + table + " (prod_dm, carr_dm, timestamp, workstation) VALUES(:prod_dm, :carr_dm, :timestamp, :workstation)", conn);
                cmd.Parameters.Add(new NpgsqlParameter("prod_dm", mainboardID));
                cmd.Parameters.Add(new NpgsqlParameter("carr_dm", carrTbx.Text));
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

        //making a query with the product and the carrier, and telling the operator what to do!
        //A - product first time in the line TOP - query no result
        //B - product second time but with BOT - query 1 result / no result?
        //C - product goes in again with TOP - ERROR BOT NEEDS TO BE DONE
        //D - product goes in again with BOT - ERROR PRODUCT IS FINISHED
        private string Interlock(string table)
        {
            try
            {
                if (table != "Hiba, nem megfelelő adat!")
                {
                    string connstring = ConfigurationManager.ConnectionStrings["CCTrace.Properties.Settings.CCDBConnectionString"].ConnectionString;
                    // Making connection
                    var conn = new NpgsqlConnection(connstring);
                    conn.Open();
                    // building query
                    var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM " + table + " WHERE prod_dm = :prod_dm", conn);
                    cmd.Parameters.Add(new NpgsqlParameter("prod_dm", mainboardID));
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

                    //1 oldal esetén lekérni a KERET számát és ha az eltér az aktuálistól akkor hiba!
                    else if (countProd == 1)
                    {
                        conn.Open();
                        cmd = new NpgsqlCommand("SELECT COUNT(*) FROM " + table + " WHERE prod_dm = :prod_dm AND carr_dm = :carr_dm ", conn);
                        cmd.Parameters.Add(new NpgsqlParameter("prod_dm", mainboardID));
                        cmd.Parameters.Add(new NpgsqlParameter("carr_dm", carrTbx.Text));
                        Int16 countProdAndCarr = Convert.ToInt16(cmd.ExecuteScalar());
                        conn.Close();
                        if (countProdAndCarr == 1)
                        {
                            outputLbl.Text = "HIBA!";
                            outputMsgLbl.Text = "Ennek a terméknek ez a fele már lakkozott!";
                            return "error";
                        }
                        else if (countProdAndCarr == 0) //ha másik keretbe került akkor itt átmegy, ellenőrizni kell, hogy ha nincs találat akkor a keret új?
                        {
                            //itt a keret és a termék páros nem szerepel az adatbázisban, akkor megnézem, hogy a termék mivel szerepel és azt hasonlítom össze a jelenlegivel
                            conn.Open();
                            cmd = new NpgsqlCommand("SELECT carr_dm FROM " + table + " WHERE prod_dm = :prod_dm ", conn);
                            cmd.Parameters.Add(new NpgsqlParameter("prod_dm", mainboardID));
                            string getCarrUsedBefore = Convert.ToString(cmd.ExecuteScalar());
                            conn.Close();
                            //le kell szednem az utolsó 2 karaktert és összehasonlítani, ha nem egyezik akkor keret csere történt
                            string getIdOfCarrUsedBefore = (Regex.Match(getCarrUsedBefore, @"\d{2}$")).ToString();
                            string getIdOfCarrUsedNow = (Regex.Match(carrTbx.Text, @"\d{2}$")).ToString();
                            if (Int16.Parse(getIdOfCarrUsedBefore) == Convert.ToInt16(getIdOfCarrUsedNow))
                            {
                                return "pass";
                            }
                            else
                            {
                                outputMsgLbl.Text = "HIBA: keret csere történt, a termék korábban a " + getIdOfCarrUsedBefore + " számú kerettel lett lakkozva!!!";
                                return "error";
                            }
                        }
                        else return "error";

                    }
                    else if (countProd == 2)
                    {
                        outputLbl.Text = "HIBA!";
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

        private void DailyProduction()
        {
            string connstring = ConfigurationManager.ConnectionStrings["CCTrace.Properties.Settings.CCDBConnectionString"].ConnectionString;
            // Making connection
            var conn = new NpgsqlConnection(connstring);
            conn.Open();
            // building query
            var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM bmw WHERE timestamp > 'today'", conn);
            Int32 countbmw = Convert.ToInt32(cmd.ExecuteScalar());
            cmd = new NpgsqlCommand("SELECT COUNT(*) FROM volvo WHERE timestamp > 'today'", conn);
            Int32 countvolvo = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            dailyProdLbl.Text = "Mai napon lakkozva \r\n";
            dailyProdLbl.Text += "BMW db:";
            dailyProdLbl.Text += " " + countbmw.ToString();
            dailyProdLbl.Text += "\r\nVolvo db:";
            dailyProdLbl.Text += " " + countvolvo.ToString();
            int sum = countvolvo + countbmw;
            if (sum % 100 == 0)
            {
                MessageBox.Show("Ellenőrizd a lakk mennyiségét! Ha utántöltés szükséges akkor kattints a 'Lakk feltöltése gombra!' ");
            }

        }

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        private void ReturnCurrentVarnish()
        {
            try
            {
                // connstring stored in App.config
                string connstring = ConfigurationManager.ConnectionStrings["CCTrace.Properties.Settings.CCDBConnectionString"].ConnectionString;
                var conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = "SELECT batch, expdate, timestamp" +
                    " FROM lakk order by timestamp desc limit 2";
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

                dataGridView1.Columns[0].HeaderText = "BATCH SZÁM";
                dataGridView1.Columns[1].HeaderText = "SZAVATOSSÁG";
                dataGridView1.Columns[2].HeaderText = "BETÖLTÉS";
            }
            catch (Exception msg)
            {
                // error handling
                MessageBox.Show(msg.ToString());
                //throw;
            }
            dataGridView1.ClearSelection();
        }

        private string ReturnTableName()
        {
            if (carrTbx.Text.Contains("BMW"))
                return "bmw";
            else if (carrTbx.Text.Contains("VOLVO"))
                return "volvo";
            else
                return "Hiba, nem megfelelő adat!";
        }

        private void ClearForm()
        {
            carrTbx.Text = "";
            prodTbx.Text = "";
            prodTbx.Focus();
            prodTbx.SelectAll();
        }


        //Thread.Sleep(150);
        //tableLayoutPanel1.BackColor = Color.Red;
        //Thread.Sleep(150);
        //tableLayoutPanel1.BackColor = Color.White;
        private async void ErrorBlinking()
        {
            int i = 0;
            while (i < 12)
            {
                await Task.Delay(500);
                tableLayoutPanel1.BackColor = tableLayoutPanel1.BackColor == Color.Red ? SystemColors.Control : Color.Red;
                i = i + 1;
            }
            tableLayoutPanel1.BackColor = Color.Red;
            outputMsgLbl.ForeColor = Color.Black;
        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //check data and upload to database, update CSV, and save to pendrive
            //update window with large label stating if this product have to be removed or proceed to other side
            HsOrMb();
            PreChkResult = PreCheck();
            if (PreChkResult)
            {

                if (DataValid())
                {
                    string interlocking = Interlock(ReturnTableName());
                    if (interlocking == "pass")
                    {
                        //SaveToFile();
                        //check if product has been already read
                        Db_insert(ReturnTableName());
                        tableLayoutPanel1.BackColor = SystemColors.Control;
                        outputMsgLbl.ForeColor = System.Drawing.Color.Green;
                        outputMsgLbl.Text = "Adatok elmentve!" + "\r\n" + prodTbx.Text + "\r\n" + carrTbx.Text + "\r\n" + DateTime.Now;
                    }
                    else ErrorBlinking();
                }
                else ErrorBlinking();
            }
            else
            {
                ErrorBlinking();
                MessageBox.Show("A TERMÉK NINCS TESZTELVE! NE LAKKOZD, SZÓLJ A MŰSZAKVEZETŐNEK!");
                outputMsgLbl.Text = "A TERMÉK NINCS TESZTELVE! NE LAKKOZD, SZÓLJ A MŰSZAKVEZETŐNEK!";
            }

            ReturnCurrentVarnish();
            DailyProduction();
            ClearForm();
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(this);
            frm.Show();
        }

        private void VarnBtn_Click(object sender, EventArgs e)
        {
            var frm = new form4(this);
            frm.Show();
        }
    }
}
