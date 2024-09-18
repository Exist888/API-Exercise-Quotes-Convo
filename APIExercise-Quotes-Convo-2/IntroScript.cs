namespace APIExercise_Quotes_Convo_2;

public class IntroScript
{
    public void IntroScene()
    {
        var clientRound1 = new HttpClient();
        var introQuotes = new QuoteGenerator(clientRound1);

        Console.WriteLine("\n" +
                          "SCENE:\n" +
                          "A mild, late-summer afternoon. An outdoor cafe in Southern Italy.\n" +
                          "Ron Swanson sits alone at a brittle table,\n" +
                          "reading Marcus Aurelius, then pausing to stare afar.\n" +
                          "\n" +
                          "Kanye West pulls up in a limo, sits a table away from Swanson,\n" +
                          "thanks the waitress who brings him a tiny espresso cup,\n" +
                          "and drops a 500 dollar tip on the table.\n" +
                          "\n" +
                          "KANYE:\n" +
                          "Ron Swanson? Is that you?\n" +
                          "");

        Console.WriteLine($"SWANSON:\n" +
                          $"Well, if it isn't Kanye West.\n" +
                          $"Let me tell you something, Kanye:\n" +
                          $"{introQuotes.SwansonSpeaks()}\n" +
                          $"");

        Console.WriteLine($"KANYE:\n" +
                          $"I have never heard such malarkey, Swanson.\n" +
                          $"I'll go ahead and tell you something:\n" +
                          $"{introQuotes.KanyeSpeaks()}.\n" +
                          $"");

        Console.WriteLine($"SWANSON:\n" +
                          $"Now this is getting out of hand, Kanye.\n" +
                          $"It is time for a quote face-off.\n" +
                          $"");

        Console.WriteLine($"KANYE:\n" +
                          $"Deal, Swanson. You go first.\n" +
                          $"");

        Console.WriteLine($"SWANSON:\n" +
                          $"No, ladies first, I insist.\n" +
                          $"");

        Console.WriteLine($"KANYE:\n" +
                          $"As already stated, I have never heard such malarkey, Swanson.\n" +
                          $"You can go ahead take that honor.\n" +
                          $"");

        Console.WriteLine($"SWANSON:\n" +
                          $"Touche, considering that you just went first,\n" +
                          $"I shall now proceed:\n" +
                          $"");
    }
}