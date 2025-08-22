namespace screen_sound_4.Modelos;
using System.Text.Json;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas sãos as músicas favoritas de {Nome}:");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($" - {musica.Nome} do artista {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        }); //objeto anônimo
        string nomeDoArquivo = $"musicas-favoritas- {Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Arquivo Json {nomeDoArquivo} criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");

    }

}
