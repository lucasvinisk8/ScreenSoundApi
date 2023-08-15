using ScreeSound_Api.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
    string resposta = await client.GetStringAsync("http://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[25].ExibirDetalhesDaMusica();
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}