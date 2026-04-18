using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

public class Film
{
    public string title { get; set; }
    public string genre { get; set; }
    public string year { get; set; }
    public string director { get; set; }
    public int rating { get; set; }
    public int durationMinutes { get; set; }
    public bool IsWatched { get; set; }
}
public class FilmFavorit_103022400010
{
    public void ReadJSON()
    {
        string jsonString = File.ReadAllText(
            @"D:\MODUL7\Modul7_Kelompok2\Modul7_Kelompok2\jurnal7_1_103022400010.json"
        );
        
        Film flm = JsonSerializer.Deserialize<Film>(jsonString);

        Console.WriteLine("===== Data Film Favorit =====");
        Console.WriteLine("Judul: " + flm.title);
        Console.WriteLine("Sutradara: " + flm.director);
        Console.WriteLine("Tahun Rilis: " + flm.year);
        Console.WriteLine("Genre: " + flm.genre); 
        Console.WriteLine("Rating: " + flm.rating);
        Console.WriteLine("Duration: " + flm.durationMinutes);
        Console.WriteLine("Is Watched: " + flm.IsWatched);
        Console.WriteLine("=============================");
    }
}