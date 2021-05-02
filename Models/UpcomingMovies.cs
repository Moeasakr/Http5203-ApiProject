using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiProjectV2.Models
{

    public class UpcomingMovies
    {
        public Movie[] items { get; set; }
        public string errorMessage { get; set; }
    }

    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public string fullTitle { get; set; }
        public string year { get; set; }
        public string releaseState { get; set; }
        public string image { get; set; }
        public string runtimeMins { get; set; }
        public string runtimeStr { get; set; }
        public string plot { get; set; }
        public string contentRating { get; set; }
        public string imDbRating { get; set; }
        public string imDbRatingCount { get; set; }
        public string metacriticRating { get; set; }
        public string genres { get; set; }
        public Genrelist[] genreList { get; set; }
        public string directors { get; set; }
        public Directorlist[] directorList { get; set; }
        public string stars { get; set; }
        public Starlist[] starList { get; set; }
    }

    public class Genrelist
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Directorlist
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Starlist
    {
        public string id { get; set; }
        public string name { get; set; }
    }

}