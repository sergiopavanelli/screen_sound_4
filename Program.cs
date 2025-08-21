using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}