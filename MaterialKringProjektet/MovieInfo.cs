using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MaterialKringProjektet {
    public class MovieInfo {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public Rating[] Ratings { get; set; }
        public string Metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string DVD { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        public string Website { get; set; }
        public string Response { get; set; }

        static MovieInfo mi; 

       // public static MovieInfo GetInfoFromOpenMovieDatabase(string searchword) {
       // }

       /* async Task RunAsync() {
            using (var client = new HttpClient()) {
                //   client.Timeout = TimeSpan.FromSeconds(10);
                client.BaseAddress = new Uri("http://www.omdbapi.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response =  client.GetAsync("?apikey=ee15dad6&t=" + searchword);
                if (response.IsSuccessStatusCode) {
                   return  response.Content.ReadAsAsync<MovieInfo>();
                   
                } else {
                    return null; 
                }
            }
        } */
    }

    public class Rating {
        public string Source { get; set; }
        public string Value { get; set; }
    }


    
}
