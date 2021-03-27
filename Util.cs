// Import packages
using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        public static void
        PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }
        // Add another static method to Util class which will make our CSV file.

        public static void MakeCSV(List<Employee> employees)
        {
            // Check to see if folder exists
            if (!Directory.Exists("data"))
            {
                //If not, create it 
                Directory.CreateDirectory("data");
            }

            // Add another static method to Util class which will make our CSV file.

            using (StreamWriter file = new
            StreamWriter("data/employees.csv"))
            {
                file.WriteLine("ID,Name,PhotoUrl");

                // Loop over the given employees.

                for (int i = 0; i < employees.Count; i++)

                // Write each employee’s info as a comma-separated string to the CSV file.
                {
                    string template = "{0},{1},{2}";
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
                }
            }



        }


    }
}

// // Add another static method to Util class which will make our CSV file.

// using (StreamWriter file = new
// StreamWriter("data/employees.csv"))
// {
//     file.WriteLine("ID,Name,PhotoUrl");

//     // Loop over the given employees.

//     for (int i = 0; i < employees.Count; i++)

//     // Write each employee’s info as a comma-separated string to the CSV file.
//     {
//         string template = "{0},{1},{2}";
//         file.WriteLine(String.Format(template,employees[i].GetId(),employees[i].GetName(),employees[i].GetPhotoUrl()));
//     }
// }