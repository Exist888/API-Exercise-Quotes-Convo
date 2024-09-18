using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace APIExercise_Quotes_Convo_2;

public class QuoteGenerator
{
    private HttpClient _client;

    public QuoteGenerator(HttpClient client)
    {
        _client = client;
    }

    public string KanyeSpeaks()
    {
        var kanyeUrl = "https://api.kanye.rest";
        var kanyeResponse = _client.GetStringAsync(kanyeUrl).Result;
        var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
        return kanyeQuote;
    }

    public string SwansonSpeaks()
    {
        var swansonUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        var swansonResponse = _client.GetStringAsync(swansonUrl).Result;
        //var swansonQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        var swansonQuote = JsonArray.Parse(swansonResponse)[0].ToString();
        return swansonQuote;
    }
}