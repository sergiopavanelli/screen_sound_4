namespace screen_sound_4.Modelos;

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

}
