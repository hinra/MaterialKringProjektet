using MySql.Data.MySqlClient;
using System.Data;


namespace Class2Table {
    public class kunder {
        private DataRow dr;

        public static MySqlCommand generateSelectCmd(string id) {

            MySqlCommand myc = new MySqlCommand("Select * from kunder where Kund_ID = @ID");
            myc.Parameters.AddWithValue("@ID", id);
            return myc;
        }


        public kunder() {
            // tom konstruktör
        }

        public kunder(DataRow dr) {
            this.Kund_ID = dr.Field<string>("Kund_ID");
            this.FirmaNamn = dr.Field<string>("FirmaNamn");
            this.KontaktNamn = dr.Field<string>("KontaktNamn");
            this.KontaktTitel = dr.Field<string>("KontaktTitel"); 
            //...
        }

        public string Kund_ID { get; set; }
        public string FirmaNamn { get; set; }
        public string KontaktNamn { get; set; }
        public string KontaktTitel { get; set; }
        public string Address { get; set; }
        public string Stad { get; set; }
        public string Region { get; set; }
        public string PostNummer { get; set; }
        public string Land { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public int Omsattning { get; set; }

        public MySqlCommand getInsertCommand() {
            MySqlCommand mc = new MySqlCommand();
            mc.CommandText = "INSERT INTO kunder (Kund_ID, FirmaNamn, KontaktNamn) Values ( @ID, @FirmaNamn, @Kontakt)";
            mc.Parameters.AddWithValue("@ID", this.Kund_ID);
            mc.Parameters.AddWithValue("@FirmaNamn", this.FirmaNamn);
            mc.Parameters.AddWithValue("@Kontakt", this.KontaktNamn); 

            return mc;

        }

        public override string ToString() {
            return this.FirmaNamn + ", " 
                    + this.KontaktNamn 
                    + " (" + this.KontaktTitel + ")";
        }
    }
}
