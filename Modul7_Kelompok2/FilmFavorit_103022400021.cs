using System;
using System.Text.Json;

public class FilmFavorit
{
	public string title { get; set; }
	public string director { get; set; }
	public string year { get; set; }
	public string genre { get; set; }
	public int rating { get; set; }
	public int durationMinutes { get; set; }
	public bool isWatched { get; set; }
}

public class FilmFavorit_103022400021
{
	public void ReadJSON()
	{
		string json = File.ReadAllText(@"D:\Modul7_Kelompok2\Modul7_Kelompok2\bin\Debug\net10.0\jurnal7_1_103022400021.json");

		FilmFavorit fav = JsonSerializer.Deserialize<FilmFavorit>(json);

		Console.WriteLine($"Title: {fav.title}, Director: {fav.director}, Year: {fav.year}, Genre: {fav.genre}, Rating: {fav.rating}, Duration Minutes: {fav.durationMinutes}, Is Watched: {fav.isWatched}");
	}
}
