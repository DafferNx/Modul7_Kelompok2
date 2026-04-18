using System;
using System.Text.Json;

public class FilmPilihan
{
    public string title { get; set; }
    public string director { get; set; }
    public string year { get; set; }
    public string genre { get; set; }
    public double rating { get; set; }
    public int durationMinutes { get; set; }
    public bool isWatched { get; set; }
}

    public class FilmPilihan103022400080
    {
    public void ReadJSON()
    {
        string json = File.ReadAllText(@"D:\Modul7_Kelompok2\Modul7_Kelompok2\jurnal7_1_103022400080.json");
        FilmPilihan flm = JsonSerializer.Deserialize<FilmPilihan>(json);
        Console.WriteLine($"Judul {flm.title}, disutradarai {flm.director}, rilis pada tahun {flm.year}, bergenre {flm.genre}, mendapatkan nilai {flm.rating}, berdurasi {flm.durationMinutes}, Sudah ditonton {flm.isWatched} ");
    }
}