namespace APIExercise_Quotes_Convo_2;

//Disclaimer: Characters' opinions are not necessarily those of the programmer :)

class Program
{
    static void Main(string[] args)
    {
        var client = new HttpClient();
        var quote = new QuoteGenerator(client);
        var intro = new IntroScript();
        intro.IntroScene();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"KANYE:\n" +
                              $"Not so fast, Ron. {quote.KanyeSpeaks()}.\n" +
                              $"");
            Console.WriteLine($"SWANSON:\n" +
                              $"Well, you're a wise guy, however... {quote.SwansonSpeaks()}\n" +
                              $"");
        }
    }
}