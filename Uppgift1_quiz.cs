/*
Namn
Datum

Uppgift 1 - Quiz

När programmet startar ska användaren få mata in sitt namn.

Programmet ska sedan ställa 5 frågor till användaren. 

Använd .ToLower(), ToUpper() och .ToTitleCase() för att göra det enklare att jämföra användarens svar med de rätta svaren.

När alla frågor är besvarade ska programmet skriva ut hur många rätt användaren fick.

Det ska finnas två olika ämnen/svårighetsgrader att välja på.

Kursmoment som ingår i uppgiften:
Variabler
Inmatning
If-satser


*/



using System.Net.Security;
//Start
Console.WriteLine("What is your name ?");
string what_is_name = Console.ReadLine();
Console.WriteLine($"Welcome, {what_is_name}.");

//Spel nivå
Console.WriteLine("Today you will be playing a game, to which there are two levels. Choose: 1 - Easy, 2 - Difficult.");
int difficulty = int.Parse(Console.ReadLine());

// Frågor och svar för lätt nivå
string[] easyQuestions = 
{
    "What is 2 + 2?",
    "What color is the sky on a clear day?",
    "How many legs does an avrage spider have?",
    "What is Sweden's capital city?",
    "What is the biggest animal in the world?"
};
string[] easyAnswers = { "4", "blue", "8", "stockholm", "blue whale" };

// Frågor och svar för svår nivå
string[] difficultQuestions = 
{
    "What is the square root of 144?",
    "What year did the french revolution end?",
    "Who was president of America year 1967?",
    "What is the atomic mass of gold?",
    "How many continents are there?"
};
string[] difficultAnswers = { "12", "1799", "Lyndon Baines Johnson", "196.97", "7" };


string[] chosenQuestions;
string[] chosenAnswers;

if (difficulty == 1)
{
    chosenQuestions = easyQuestions;
    chosenAnswers = easyAnswers;
}
else
{
    chosenQuestions = difficultQuestions;
    chosenAnswers = difficultAnswers;
}

int points = 0;

for (int i = 0; i < chosenQuestions.Length; i++)
{
    Console.WriteLine(chosenQuestions[i]); // Ställer frågan
    string userAnswer = Console.ReadLine().ToLower(); // Läs in svar och konvertera till gemener

    if (userAnswer == chosenAnswers[i].ToLower()) // Jämför oberoende av skiftläge
    {
        Console.WriteLine("That's right!");
        points++;
    }
    else
    {
        Console.WriteLine("Wrong! Correct answer was: " + chosenAnswers[i]);
    }
}

Console.WriteLine($"You got {points} of {chosenQuestions.Length} correct!");