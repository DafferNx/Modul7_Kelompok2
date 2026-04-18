using System;
using System.Text.Json;

public class Film
{
    public string title { get; set; }
    public string director { get; set; }
    public string year { get; set; }
    public string genre { get; set; }
    public int rating { get; set; }
    public int durationMinutes { get; set; }
    public bool isWatched { get; set; }
}

public class FilmFavorit_103022400112
{

    public void readJSON()
    {
        string jsonFilePath = "D:/Modul7_Kelompok2/Modul7_Kelompok2/bin/Debug/net10.0/jurnal7_1_103022400112.json";
        string jsonString = File.ReadAllText(jsonFilePath);
        Film film = JsonSerializer.Deserialize<Film>(jsonString);
        Console.WriteLine("Title: " + film.title);
        Console.WriteLine("Director: " + film.director);
        Console.WriteLine("Year: " + film.year);
        Console.WriteLine("Genre: " + film.genre);
        Console.WriteLine("Rating: " + film.rating);
        Console.WriteLine("Duration (minutes): " + film.durationMinutes);
        Console.WriteLine("Watched: " + (film.isWatched ? "Yes" : "No"));
    }
}
