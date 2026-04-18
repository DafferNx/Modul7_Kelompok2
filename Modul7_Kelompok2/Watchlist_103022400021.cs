using System.Text.Json;

public class Movie
{
    public string id { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string genre { get; set; }
    public double rating { get; set; }
}

public class Watchlist
{
    public string watchlistName { get; set; }
    public string createdBy { get; set; }
    public List<Movie> movies { get; set; }
}

public class Watchlist_103022400021
{
    public void ReadJSON()
    {
        string json = File.ReadAllText(@"D:\Modul7_Kelompok2\Modul7_Kelompok2\bin\Debug\net10.0\jurnal7_2_103022400021.json");
        Watchlist watchlist = JsonSerializer.Deserialize<Watchlist>(json);
        Console.WriteLine("Watchlist Name : " + watchlist.watchlistName);
        Console.WriteLine("Created By : " + watchlist.createdBy);
        Console.WriteLine("Movies : ");
        foreach (Movie movie in watchlist.movies) {
            Console.WriteLine($"{movie.id} {movie.title} ({movie.year} - {movie.rating})");
        }
    }
}