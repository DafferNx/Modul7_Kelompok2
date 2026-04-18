using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Film
{
    public string title { get; set; }
    public string director { get; set; }
    public string year { get; set; }
    public string genre { get; set; }
    public int rating { get; set; }
    public int durationMinutes { get; set; }
    public Boolean isWatched { get; set; }
}
public class FilmFavorit_103022400027_fadhil
{
	
    public FilmFavorit_103022400027_fadhil()
	{

	}
	public void ReadJSON()
	{
		string JSON = File.ReadAllText(@"D:\Modul7_Kelompok2\Modul7_Kelompok2\jurnal7_1_103022400027.json");
		Film film = JsonSerializer.Deserialize<Film>(JSON);
		Console.WriteLine("Judul: " + film.title);
        Console.WriteLine("Director: " + film.director);
        Console.WriteLine("Year: " + film.year);
        Console.WriteLine("Genre: " + film.genre);
        Console.WriteLine("Rating: " + film.rating);
        Console.WriteLine("Durasi: " + film.durationMinutes);
        Console.WriteLine("Watched?: " + film.isWatched);
    }
}
