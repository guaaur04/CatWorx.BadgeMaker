using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // string greeting = "Hello";
            // greeting = greeting + "World";
            // Console.WriteLine("greeting" + greeting);

            // double side = 3.14;
            // double area = side * side;
            // Console.WriteLine("area: {0}", area.GetType());

            // Console.WriteLine(2*3);
            // Console.WriteLine(10 % 3);
            // Console.WriteLine(1 + 2 * 3);
            // Console.WriteLine(10/3);
            // Console.WriteLine("12"+"3");

            // int num = 10;
            // num += 100;
            // Console.WriteLine(num);
            // num ++;
            // Console.WriteLine(num);

            // bool isCold = true;
            // Console.WriteLine(isCold ? "drink" : "add ice");

            // Console.WriteLine(!isCold ? "drink": "add ice");

            //    string stringNum ="2";
            //    int intNum = Convert.ToInt16(stringNum);
            //    Console.WriteLine(intNum);
            //    Console.WriteLine(intNum.GetType());

            //     Dictionary<string, int> myScoreBoard = new
            //     Dictionary<string, int>(){
            //         {"firstInning", 10},
            //         {"secondInning", 20},
            //         {"thirdInning", 30},
            //         {"fourthInning", 40},
            //         {"fifthInning", 50},
            //    };

            //     Console.WriteLine("----------------");
            //     Console.WriteLine("  Scoreboard");
            //     Console.WriteLine("----------------");
            //     Console.WriteLine("Inning |  Score");
            //     Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            //     Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            //     Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            //     Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            //     Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

            // string[] favFoods = new string[3] { "pizza", "doughnuts", "icecream" };
            // string firstFood = favFoods[0];
            // string secondFood = favFoods[1];
            // string thirdFood = favFoods[2];
            // Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

            List<string> employees = new List<string>() { "ximena", "noa" };
            employees.Add("celestina");
            employees.Add("delfina");
            Console.WriteLine("Please enter a name: ");
            // Get a name from the console and assign it to a variable
            string input = Console.ReadLine();
            employees.Add(input);
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
