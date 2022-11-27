using MassFood.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MassFood.Controllers
{
    public class HomeController : Controller
    {
        string Baseurl = "https://mass-data-food-api.herokuapp.com/";

        public async Task<ActionResult> Index()
        {
            List<Foods> FoodIfo = new List<Foods>();

            using (var client = new HttpClient())
            {
                //Passing service base url

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();

                //Define request data format

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllFoods using HttpClient

                HttpResponseMessage Res = await client.GetAsync("breakfast");

                //Checking the response is successful or not which is sent using HttpClient

                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api 

                    var FoodResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Food list

                    FoodIfo = JsonConvert.DeserializeObject<List<Foods>>(FoodResponse);

                }
                //returning the Food list to view

                return View(FoodIfo);
            }
        }
    }
}