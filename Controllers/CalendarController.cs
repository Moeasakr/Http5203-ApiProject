using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Serialization;
using ApiProjectV2.Models;
using Newtonsoft.Json;

namespace ApiProjectV2.Controllers
{
    public class CalendarController : Controller
    {
        private static readonly HttpClient client;

        static CalendarController()
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                AllowAutoRedirect = false
            };
            client = new HttpClient(handler);
            client.BaseAddress = new Uri("http://30boxes.com/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public ActionResult GetUser(string email)
        {
            string url = "api.php?method=user.FindByEmail&apiKey=8608785-c17eb929136593f185fe810849e33367&email=" + email;
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
           {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response.Content.ReadAsStringAsync().Result);

                //Reference: https://stackoverflow.com/questions/33175427/parsing-xml-in-c-sharp-from-xml-rest-post-webresponse
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(response.Content.ReadAsStringAsync().Result)))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(rsp));
                    rsp rspObject = (rsp)serializer.Deserialize(ms);

                    return View(rspObject);
                }
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        [HttpGet]
        public ActionResult AddMovieToUserCalendar(string movieTitle, string date)
        {
            string calendarEntry = movieTitle + "will be released today.";
            date = ConvertDate(date);
            string url = "api.php?method=events.AddByElements&apiKey=8608785-c17eb929136593f185fe810849e33367&authorizedUserToken=8608785-557b5b3557f70ee2558ac3bb1084435a&summary=" + calendarEntry + "&dateStart=" + date;
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Imdb");
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

        public string ConvertDate(string date)
        {
            string formattedDate = "";
            if (date.Contains("May"))
            {
                formattedDate = date.Replace("May ", "5/");
            }
            return formattedDate;
        }
    }
}