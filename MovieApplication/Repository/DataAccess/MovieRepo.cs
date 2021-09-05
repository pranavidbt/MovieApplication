using MovieApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Repository.DataAccess
{
    public class MovieRepo : IMovieRepo
    {
        public MovieRepo()
        {

        }
        MovieWrapper IMovieRepo.GetMovie()
        {
            MovieWrapper mw = null;
            using (StreamReader r = new StreamReader(@"C:\\Users\\d pranavi\\source\\repos\\MovieApplication\\MovieApplication\\Repository\\Movies.json"))
            {
                string json = r.ReadToEnd();
                mw = JsonConvert.DeserializeObject<MovieWrapper>(json);
            }
            return mw;
        }
    }
}
