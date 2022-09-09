
using Newtonsoft.Json.Linq;

var client = new HttpClient();
var kanyeURL = "https://api.kanye.rest/";
var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

for (int i = 0; i < 5; i++)
{

    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
    Console.WriteLine();
    var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
    Console.WriteLine();
    var ronResponse = client.GetStringAsync(ronSwansonURL).Result;
    Console.WriteLine();
    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
    Console.WriteLine();

    Console.WriteLine(kanyeQuote);
    Console.WriteLine(ronQuote);

}
