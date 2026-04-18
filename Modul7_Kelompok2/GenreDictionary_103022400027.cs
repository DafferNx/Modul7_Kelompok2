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

public class GenreDictionary_103022400027
{
    public void ReadJSON()
    {
        string JSON = File.ReadAllText(@"D:\Modul7_Kelompok2\Modul7_Kelompok2\jurnal7_3_103022400027.json");
        GenreDictionaryContainer genreContainer = JsonSerializer.Deserialize<GenreDictionaryContainer>(JSON);
        Console.WriteLine("--- Genre Dictionary ---");
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