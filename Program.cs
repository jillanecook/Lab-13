using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus13actual
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to the C# Parking Garage!");
                Console.WriteLine("What kind of vehicle do you have?");
                string input = Console.ReadLine(); //user inputs type of car


                List<Vehicle> vehicle = new List<Vehicle>();
                Vehicle m = new Vehicle("motorcycle", "motor spots", "7");
                vehicle.Add(m);
                Vehicle c = new Vehicle("car", "small compact spots", "20");
                vehicle.Add(c);
                Vehicle b = new Vehicle("bus", "large spots", "2");
                vehicle.Add(b);

                Spots w = new Spots(vehicle);

                w.PrintbyType(input);
               

                // is there a way to reduce the number of spots after console has run?
                // trying to figure a way to show how many spots are LEFT- the count in the list is the starting amount 
                

            } while (Continue() == true);

        }

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("Does not compute!");
                run = Continue();

            }
            return run;
        }
    }
        }


    

