class Program
{
    static void Main(string[] args)
    {
        FilmPilihan103022400080 data = new FilmPilihan103022400080();
        data.ReadJSON();

        WatchList103022400080 wl = new WatchList103022400080();
        wl.ReadJSON();
    }
}
