using System;
using System.Text.Json;

public class GenreDictionaryContainer
{ 
    public GenreDict GenreDictionary { get; set; }
}

public class GenreDict
{
    public string category { get; set; }
    public Genre GenreInfo { get; set; }
}
public class Genre
{
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public List<String> popularMovies { get; set; }
}

public class GenreDictionary_103022400112
{
   public void readJSON()
    {
        string jsonString = File.ReadAllText("D:/Modul7_Kelompok2/Modul7_Kelompok2/bin/Debug/net10.0/jurnal7_3_103022400112.json");
        GenreDictionaryContainer genreContainer = JsonSerializer.Deserialize<GenreDictionaryContainer>(jsonString);
        Console.WriteLine("Category: " + genreContainer.GenreDictionary.category);
        Console.WriteLine("ID: " + genreContainer.GenreDictionary.GenreInfo.id);
        Console.WriteLine("Name: " + genreContainer.GenreDictionary.GenreInfo.name);
        Console.WriteLine("Description: " + genreContainer.GenreDictionary.GenreInfo.description);
        Console.WriteLine("Popular Movies:");
        foreach (var movie in genreContainer.GenreDictionary.GenreInfo.popularMovies)
        {
            Console.Write(movie + ", ");
        }
    }

}
