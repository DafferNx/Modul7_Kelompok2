class Modul7_Kelompok2
{
    static void Main(string[] args)
    {
        FilmFavorit_103022400021 filmFavorit = new FilmFavorit_103022400021();
        filmFavorit.ReadJSON();

        Watchlist_103022400021 watchlist = new Watchlist_103022400021();
        watchlist.ReadJSON();
    }
}