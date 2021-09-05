using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MovieApplication.Models
{
    public class Movie
    {
        [JsonConstructor]
        public Movie(string language, string location,
           string plot,
           string poster,
           List<string> soundEffects,
           List<string> stills,
           string title,
           string imdbID,
           string listingType,
           string imdbRating)
        {
            this.Language = language;
            this.Location = location;
            this.Plot = plot;
            this.Poster = poster;
            this.SoundEffects = soundEffects;
            this.Stills = stills;
            this.Title = title;
            this.ImdbID = imdbID;
            this.ListingType = listingType;
            this.ImdbRating = imdbRating;
        }

        [JsonPropertyName("Language")]
        public string Language { get; }

        [JsonPropertyName("Location")]
        public string Location { get; }

        [JsonPropertyName("Plot")]
        public string Plot { get; }

        [JsonPropertyName("Poster")]
        public string Poster { get; }

        [JsonPropertyName("SoundEffects")]
        public IReadOnlyList<string> SoundEffects { get; }

        [JsonPropertyName("Stills")]
        public IReadOnlyList<string> Stills { get; }

        [JsonPropertyName("Title")]
        public string Title { get; }

        [JsonPropertyName("imdbID")]
        public string ImdbID { get; }

        [JsonPropertyName("listingType")]
        public string ListingType { get; }

        [JsonPropertyName("imdbRating")]
        public string ImdbRating { get; }
    }
}
