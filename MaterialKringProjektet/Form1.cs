using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialKringProjektet {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
          
        }


        

        private void button1_Click(object sender, EventArgs e) {

            _ = RunAsync(); 

        }

         async Task RunAsync() {
            using (var client = new HttpClient()) {
             //   client.Timeout = TimeSpan.FromSeconds(10);
                client.BaseAddress = new Uri("http://www.omdbapi.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("?apikey=ee15dad6&t=the%20Godfather");
                if (response.IsSuccessStatusCode) {
                    MovieInfo product = await response.Content.ReadAsAsync < MovieInfo > ();
                    textBox1.AppendText(product.Title + product.Year +  product.Released);
                }
                else { 
                    textBox1.AppendText(response.Headers.ToString()); 
                }
            }
        }
    }
}
