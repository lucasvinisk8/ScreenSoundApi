
using ScreeSound_Api.Modelos;

namespace ScreeSound_Api.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero)
                                            .Distinct()
                                            .ToList();

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musicas => musicas.Genero!.Contains(genero))
                                              .Select(musicas => musicas.Artista)
                                              .Distinct()
                                              .ToList();

        Console.WriteLine($"Artistas Por Gênero Musical");

        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musicas => musicas.Artista!.Equals(artista))
                                      .Select(musicas => musicas.Nome)
                                      .Distinct()
                                      .ToList();
           
        Console.WriteLine($"Músicas do Artista - {artista}");

        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"Música {musicasDoArtista.IndexOf(musica) + 1} - {musica}");
        }
    }
}
