using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Class2Table {
    public partial class Form1 : Form {

        DBKommunikator dbKomm;
        DataTable dtab = new DataTable();
        MySqlDataAdapter mdat = new MySqlDataAdapter();
        string connectionString = "SERVER=localhost;DATABASE=northwind;UID=lennart;PASSWORD=abcdef"; // ändra för dina behov
        MySqlConnection conn;

        public Form1() {
            InitializeComponent();
            conn = new MySqlConnection(connectionString);
            dbKomm = new DBKommunikator();
            dbKomm.ConnectionString = connectionString;
        }

        private void button1_Click(object sender, EventArgs e) {

            MySqlCommand cmd = new MySqlCommand();
            // förberedda kommandot
            cmd.CommandText = "Select Kund_ID , FirmaNamn, KontaktNamn from kunder";
            cmd.Connection = conn;
            mdat.SelectCommand = cmd;

            conn.Open();
            // skicka sql-sats och fyll dtab med all data. 
            mdat.Fill(dtab);

            // hela dataTable till dataGridView
            dataGridView1.DataSource = dtab;
            conn.Close();

            foreach (DataRow dr in dtab.Rows) {
                listBox1.Items.Add(dr.Field<string>("Kund_ID"));
            }

            /* Variant #1
             
             Dictionary<string, string> list = new Dictionary<string, string>();
             foreach(DataRow dr in dtab.Rows){
                list.Add(dr.Field<string>("Kund_ID"), dr.Field<string>("FirmaNamn"));
            }
            listBox1.DataSource = new BindingSource(list, null);
            listBox1.DisplayMember = "Value";
            listBox1.ValueMember = "Key";
             */

        }

        private void btn_getOne_Click(object sender, EventArgs e) {
            //string kund_ID = listBox1.SelectedValue.ToString();  Behov för variant #1
            string kund_ID = listBox1.SelectedItem.ToString();
            MySqlCommand enKundCmd = kunder.generateSelectCmd(kund_ID);
            DataRow dr = dbKomm.SelectOneCommand(enKundCmd);
            kunder k = new kunder(dr);
            label1.Text = "Kunduppgifter: " + Environment.NewLine + k.ToString();

        }
    }
}
