/*
Namn  
Datum  

Uppgift 5 - To Do List

Din uppgift är att fylla i de if-satser där det nu står 'pass' så att programmet fungerar som det ska.
 */ 

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> toDoList = new List<string>();  // Skapa en tom lista för saker att göra
        while (true)
        {
            Console.WriteLine("1. Lägg till sak att göra");
            Console.WriteLine("2. Stryk sak från listan");
            Console.WriteLine("3. Skriv ut listan");
            Console.WriteLine("4. Avsluta program");
            
            string menyval = Console.ReadLine();

            if (menyval == "1")
            {
                // Fyll i kod här för att lägga till en sak till listan
                pass;
            }
            else if (menyval == "2")
            {
                // Fyll i kod här för att ta bort en sak från listan
                pass;
            }
            else if (menyval == "3")
            {
                // Fyll i kod här för att skriva ut alla saker i listan
                pass;
            }
            else if (menyval == "4")
            {
                break;  // Avsluta programmet
            }
            else
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
            }
        }
    }
}
