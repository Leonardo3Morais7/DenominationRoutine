using DenominationRoutineLibrary.Domain;
using DenominationRoutineLibrary.Services;

class Program
{
    static void Main(string[] args)
    {
        WriteHeader();
        RunTestSuit();
        RunPersonalizedTest();
    }

    static void WriteHeader()
    {
        Console.WriteLine("Hey!");
        Console.WriteLine("My name is Leo and that's my project for the denomination routine problem");
        Console.WriteLine("Here you can run the pre defined test suit and then input new values");
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
        Console.Clear();
    }

    static void RunTestSuit()
    {
        Console.WriteLine("The current test suit is: 30, 50, 60, 80, 140, 230, 370, 610, 980 ");
        var runTestSuit = "";
        do
        {
            Console.WriteLine("Do you want to run the test suit? (y/n)");
            runTestSuit = Console.ReadLine().ToLower();
        }
        while (runTestSuit != "y" && runTestSuit != "n");

        if (runTestSuit == "y") 
        {
            WritePossibilities(30);
            WritePossibilities(50);
            WritePossibilities(60);
            WritePossibilities(80);
            WritePossibilities(140);
            WritePossibilities(230);
            WritePossibilities(370);
            WritePossibilities(610);
            WritePossibilities(980);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }     

        Console.Clear();
    }

    static void RunPersonalizedTest() 
    {
        Console.WriteLine("Now you can insert any value that you want to see the payout possibilites (multiple of 10)");
        var runNewTest = "";
        do
        {
            Console.WriteLine("Do you want to insert another value? (y/n)");
            runNewTest = Console.ReadLine().ToLower();
            if (runNewTest == "y") 
            {
                Console.Clear();
                Console.WriteLine("Insert the value: ");
                try
                {
                    var currentNumber = Convert.ToInt32(Console.ReadLine());
                    if (currentNumber % 10 != 0)
                        Console.WriteLine("That number is not a multiple of 10...");
                    else if(currentNumber > 9400) 
                        Console.WriteLine("The maximun number that the console can show is: 9400");
                    else
                        WritePossibilities(Convert.ToInt32(currentNumber));
                }
                catch 
                {
                    Console.WriteLine("Please enter a number...");
                }
            }
        }
        while (runNewTest != "n");

        Console.Clear();
    }

    static void WritePossibilities(int payout) 
    {
        Console.WriteLine("\nCurrent number: " + payout + "\n");

        var payoutCombinations = AtmPayouts.PossiblePayouts(payout);

        for (int i = 0; i < payoutCombinations.Count; i++) 
        {
            var currentCombination = "";
            foreach (var bankNotes in payoutCombinations[i]) 
            {

                if (currentCombination != "") 
                    currentCombination = currentCombination + " + ";

                currentCombination = currentCombination + (bankNotes.BankNotesCount + " x " + bankNotes.BankNotesValue + " EUR");
            }
            Console.WriteLine(currentCombination);
        }

        Console.WriteLine("\n");
    }
}