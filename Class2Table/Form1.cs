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
        string connectionString = null; // ändra för dina behov
        MySqlConnection conn;

        public Form1() {
            InitializeComponent();

            // läsa en sträng från Properties. Kolla Properties.Settings.Settings i SolutionExeplorer.
            connectionString = Properties.Settings.Default["ConnectionString"].ToString();
            conn = new MySqlConnection(connectionString);
            dbKomm = new DBKommunikator();
            dbKomm.ConnectionString = connectionString;
        }

        private void button1_Click(object sender, EventArgs e) {

            // hämta från DB utan DBKommunikator
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
            MySqlCommand enKundCmd = Kunder.generateSelectCmd(kund_ID);
            DataRow dr = dbKomm.SelectOneCommand(enKundCmd);
            Kunder k = new Kunder(dr);
            label1.Text = "Kunduppgifter: " + Environment.NewLine + k.ToString();

        }
        // 
        // FormClosing anropas när Användaren försöker stänga fönstret.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            // Spara data i Properties
            if (DialogResult.Yes == MessageBox.Show("Vill du verkligen stänga programmet?", "Are you sure?", MessageBoxButtons.YesNo)) { 
            Form1_FormClosed(sender, null); 
            } 
            else 
            {
                e.Cancel = true; // Behövs. Annars går det ändå vidare till FormClosed!
                                 // Kolla även https://stackoverflow.com/questions/47788288/how-to-cancel-closing-winform/47788302
            }
        }

        // det här körs innan det verkligen stängs
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            Properties.Settings.Default["ConnectionString"] = dbKomm.ConnectionString;
            Properties.Settings.Default.Save();
            this.Dispose(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // hämta hela raden 
                string kundID  = row.Cells[0].Value.ToString();
                MySqlCommand enKundCmd = Kunder.generateSelectCmd(kundID);
                DataRow dr = dbKomm.SelectOneCommand(enKundCmd);
                Kunder k = new Kunder(dr);
                label1.Text = "Kunduppgifter: " + Environment.NewLine + k.ToString();
            }
        }
    }
}
