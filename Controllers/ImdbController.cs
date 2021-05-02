using ApiProjectV2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ApiProjectV2.Controllers
{
    public class ImdbController : Controller
    {
        private JavaScriptSerializer jss = new JavaScriptSerializer();
        private static readonly HttpClient client;

        static ImdbController()
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                AllowAutoRedirect = false
            };
            client = new HttpClient(handler);
            client.BaseAddress = new Uri("https://imdb-api.com/en/API/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: Imdb
        [HttpGet]
        public ActionResult Index()
        {
            UpcomingMovies MovieList = new UpcomingMovies();
            string url = "ComingSoon/k_wo3pqpx0";

            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var apiResponse = response.Content.ReadAsStringAsync().Result;

                MovieList = JsonConvert.DeserializeObject<UpcomingMovies>(apiResponse);

                return View(MovieList);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult Details(string movieID, string releaseDate)
        {
            string url = "Title/k_wo3pqpx0/" + movieID;

            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var apiResponse = response.Content.ReadAsStringAsync().Result;

                MovieDetails movieDetails = JsonConvert.DeserializeObject<MovieDetails>(apiResponse);
                movieDetails.releaseState = releaseDate;

                return View(movieDetails);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }


        public ActionResult Error()
        {
            return View();
        }
    }
}