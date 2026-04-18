using System;
using System.Text.Json;

public class Movies
{
    public string id { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string genre { get; set; }
    public double rating { get; set; }

}
public class Watchlist
{
	public string watchlistName {  get; set; }
	public string createdBy { get; set; }
	public List<Movies> movies {  get; set; }
}
public class Watchlist_103022400027_fadhil

{
    public Watchlist_103022400027_fadhil()
	{
	}

	public void ReadJSON()
	{
        string JSON = File.ReadAllText(@"D:\Modul7_Kelompok2\Modul7_Kelompok2\jurnal7_2_103022400027.json");

        Watchlist watchlist = JsonSerializer.Deserialize<Watchlist>(JSON);
		Console.WriteLine("--- Watchlist Information ---");
		Console.WriteLine("Watchlist Name: " + watchlist.watchlistName);
        Console.WriteLine("Created By: " + watchlist.createdBy);
        Console.WriteLine("Watchlist Name: " + watchlist.watchlistName);

		foreach(Movies film in watchlist.movies)
		{
			Console.WriteLine(film.id + " " + film.title + " (" + film.year + " - " + film.rating + ")");
		}
    }
}
