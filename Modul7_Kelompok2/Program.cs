class Modul7_Kelompok2
{
    static void Main(string[] args)
    {
        FilmFavorit_103022400112 filmFavorit = new FilmFavorit_103022400112();
        filmFavorit.readJSON();
        Console.WriteLine();
        WatchList_103022400112 watchList = new WatchList_103022400112();
        watchList.readJSON();
    }
}