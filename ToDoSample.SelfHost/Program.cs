using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Owin.Hosting;

using ToDoSample.WebApi;

namespace ToDoSample.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = Properties.Settings.Default.BaseAddress;
            string testAddress = Properties.Settings.Default.BaseAddress.Replace("*", "localhost");

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient();

                var response = client.GetAsync(testAddress + "api/version").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                Console.ReadLine(); 
            }
        }
    }
}
