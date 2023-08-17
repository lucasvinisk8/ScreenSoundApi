using ScreeSound_Api.Modelos;
using System.Text.Json;
using ScreeSound_Api.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
    string resposta = await client.GetStringAsync("http://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}