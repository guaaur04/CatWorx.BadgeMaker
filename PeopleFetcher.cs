using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        public static List<Employee> GetFromApi() {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("Enter first name (leave empty to to exit): ");
                // Get a name from the console and assign it to a variable
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    break;
                }

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Photo URL:");
                string photoUrl = Console.ReadLine();

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }

            using (WebClient client = new WebClient())
            {
                //Image example
                string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");

                JObject json = JObject.Parse(response);

                // Console.WriteLine(json.SelectToken("results[0].name.first"));

                // Console.WriteLine(json.SelectToken("results[1].name.first"));

                // Console.WriteLine(json.SelectToken("results[2].name.first"));

                // Console.WriteLine(json.SelectToken("results"));
        

               foreach (JToken token in json.SelectToken("results")) {


                Employee emp = new Employee(
                    token.SelectToken("name.first").ToString(),

                    token.SelectToken("name.last").ToString(),

                    Int32.Parse(token.SelectToken("id.value").ToString().Replace("-","")),

                    token.SelectToken("picture.large").ToString()
                );
                employees.Add(emp);
            }
         }
         return employees;
        }
    }
    
}