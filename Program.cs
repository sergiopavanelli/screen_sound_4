using screen_sound_4.Modelos;
using System.Text.Json;
using screen_sound_4.Filtros;



using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");

        // var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        // musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        var musicasPreferidasDoEmilly = new MusicasPreferidas("Emilly");

        musicasPreferidasDoEmilly.AdicionarMusicasFavoritas(musicas[500]);
        musicasPreferidasDoEmilly.AdicionarMusicasFavoritas(musicas[637]);
        musicasPreferidasDoEmilly.AdicionarMusicasFavoritas(musicas[428]);
        musicasPreferidasDoEmilly.AdicionarMusicasFavoritas(musicas[13]);
        musicasPreferidasDoEmilly.AdicionarMusicasFavoritas(musicas[71]);

        musicasPreferidasDoEmilly.ExibirMusicasFavoritas();

        musicasPreferidasDoEmilly.GerarArquivoJson();

    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

// aplicação front-end para carregar o arquivo JSON. Acessar >> https://screen-sound.vercel.app/