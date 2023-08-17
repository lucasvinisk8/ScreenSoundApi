

using ScreeSound_Api.Modelos;

namespace ScreeSound_Api.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista)
                                       .Select(musicas => musicas.Artista)
                                       .Distinct()
                                       .ToList();

        Console.WriteLine("Lista de Artistas Ordenados");

        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
