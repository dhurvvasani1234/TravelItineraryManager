using System;
using System.Collections.Generic;

namespace Midterm
{
    class TravelAgency
    {
        static void Main(string[] args)
        {
            List<Itinerary> itineraries = new List<Itinerary>();

            Console.WriteLine("Welcome to Algonquin College Student Travel Agency!");

            Console.Write("\nEnter V to view all itineraries, A to add a new itinerary. \n" +
                            "      C to change an existing itinerary, and E to exit: ");
            string action = Console.ReadLine();
            Console.WriteLine();

                 
            //Write your code here to implement the functionality as required



            Console.WriteLine("\nThank you for using Algonquin College Student Travel Agency!");
            Console.WriteLine("Press return key to complete the application");
            Console.ReadLine();
        }
    }
}
