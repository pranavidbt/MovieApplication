using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MovieApplication.Models
{
    public class MovieWrapper
    {
        [JsonPropertyName("movies")]
        public List<Movie> movies { get; set; }
        [JsonConstructor]
        public MovieWrapper(List<Movie> _movies)
        {
            movies = new List<Movie>();
        }

    }
}
