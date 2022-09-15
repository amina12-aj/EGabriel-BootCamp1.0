var client = new HttpClient();

var a = 198772;
var request = new HttpRequestMessage
{
	Method = HttpMethod.Get,
	RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/predictions?fixture={a}"),
	Headers =
	{
		{ "X-RapidAPI-Key", "319d254bb3msh58fde8adfe8257ep1c385ajsn5398d9e9af17" },
		{ "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
	},
};
using (var response = await client.SendAsync(request))
{
	response.EnsureSuccessStatusCode();
	var body = await response.Content.ReadAsStringAsync();
	Console.WriteLine(body);
}