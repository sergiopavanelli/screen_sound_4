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
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
}
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}