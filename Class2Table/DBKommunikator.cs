using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Class2Table {
    class DBKommunikator {

        DataTable dtr; 
         
        public string ConnectionString { get; set; }

        public void InsertCommand(MySqlCommand cmd) {

        }

        public DataRow SelectOneCommand(MySqlCommand cmd){
            DataRow dr = null;
            MySqlConnection conn = new MySqlConnection(ConnectionString); 
            cmd.Connection = conn;
            DataTable dtab = new DataTable();
            MySqlDataAdapter mdat = new MySqlDataAdapter();
            mdat.SelectCommand = cmd;

            conn.Open();
            // skicka sql-sats och fyll dtab med all data. 
            mdat.Fill(dtab);

            // hela dataTable till dataGridView
            
            return dtab.Rows[0]; 
        }

        
    }
}
