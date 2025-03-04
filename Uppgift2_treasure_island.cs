/*
Namn
Datum

Uppgift 2 - Treasure Island

Öppna bilden treasure_island.png som finns i detta repository.
Gör klart det textbaserade spelet baserat på flödesschemat.

Kursmoment som ingår i uppgiften:
Variabler
Inmatning
If-satser

*/

using System.Net.Security;

class TreasureIslandGame
{
    static void Main()
    {
        Console.WriteLine("Välkommen till Skattkammarön. Ditt uppdrag är att finna skatten.");

        Console.WriteLine("Vänster eller höger?");
        string choice1 = Console.ReadLine().ToLower();

        if (choice1 == "vänster")
        {
            Console.WriteLine("Simma eller vänta?");
            string choice2 = Console.ReadLine().ToLower();

            if (choice2 == "vänta")
            {
                Console.WriteLine("Vilken dörr? (Röd, Blå, Gul)");
                string choice3 = Console.ReadLine().ToLower();

                if (choice3 == "gul")
                {
                    Console.WriteLine("Du hittade skatten! Du vinner!");
                }
                else if (choice3 == "röd")
                {
                    Console.WriteLine("Ihjälbränd. Game over.");
                }
                else if (choice3 == "blå")
                {
                    Console.WriteLine("Uppäten av bestar. Game over.");
                }
                else
                {
                    Console.WriteLine("Game over.");
                }
            }
            else
            {
                Console.WriteLine("Uppäten av fiskar. Game over.");
            }
        }
        else
        {
            Console.WriteLine("Ramlade ner i ett hål. Game over.");
        }
    }
}
