using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("http://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(resposta);
}