using System;
using System.Text.Json;

public class Movie
{
    public string id { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string genre { get; set; }
    public double rating { get; set; }
}

public class WatchList
{
    public string watchlistName { get; set; }
    public string createdBy { get; set; }
    public List<Movie> movies { get; set; }
}

public class WatchList_103022400112
{
    public void readJSON()
    {
        string jsonFilePath = "D:/Modul7_Kelompok2/Modul7_Kelompok2/bin/Debug/net10.0/jurnal7_2_103022400112.json";
        string jsonString = File.ReadAllText(jsonFilePath);
        WatchList watchList = JsonSerializer.Deserialize<WatchList>(jsonString);
        Console.WriteLine("Watchlist Name: " + watchList.watchlistName);
        Console.WriteLine("Created By: " + watchList.createdBy);
        Console.WriteLine("Movies:");
        foreach (Movie movie in watchList.movies)
        {
            Console.WriteLine(movie.id + " " + movie.title + " (" + movie.year + " - " + movie.rating + ")");
            Console.WriteLine();
        }
    }
}
