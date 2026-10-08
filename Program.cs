Random random = new();
Console.WriteLine("Välkommen! | K = Kasta tärningarna | Valfri tangent = Avsluta |");
ConsoleKey answer = Console.ReadKey().Key;

if (answer == ConsoleKey.K)
    {    

    do {

        int dice1 = random.Next(1, 7);
        int dice2 = random.Next(1, 7);
        int sum = dice1 + dice2;

        Console.WriteLine($"\nTärning ett: {dice1} | Tärning två: {dice2} | \n\nSumma: {sum}");
            
        if(sum == 12)
        {
            Console.WriteLine("Grattis! Du har vunnit :) \n\n Vill du spela igen? \n\n Tryck på K för att spela igen eller valfri tangent för att ge upp");
        }
        else
        {
            Console.WriteLine("Järnspikar också... Du fick inte 12. Vill du spela igen? Tryck på K för att spela igen eller valfri tangent för att ge upp.");
        }   
        answer = Console.ReadKey().Key;
        }
        while (answer == ConsoleKey.K);
    }

    
