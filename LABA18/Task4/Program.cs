using System.Collections;

namespace Task4
{
    public class CD
    {
        public string Title { get; set; }
        public List<string> Songs { get; set; }

        public CD(string title)
        {
            Title = title;
            Songs = new List<string>();
        }

        public void AddSong(string song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(string song)
        {
            Songs.Remove(song);
        }

        public void DisplaySongs()
        {
            foreach (var song in Songs)
            {
                Console.WriteLine(song);
            }
        }
    }

    public class CDCatalog
    {
        private Hashtable cds;

        public CDCatalog()
        {
            cds = new Hashtable();
        }

        public void AddCD(string title)
        {
            cds[title] = new CD(title);
        }

        public void RemoveCD(string title)
        {
            cds.Remove(title);
        }

        public void AddSong(string cdTitle, string song)
        {
            if (cds[cdTitle] is CD cd)
            {
                cd.AddSong(song);
            }
        }

        public void RemoveSong(string cdTitle, string song)
        {
            if (cds[cdTitle] is CD cd)
            {
                cd.RemoveSong(song);
            }
        }

        public void DisplayCatalog()
        {
            foreach (CD cd in cds.Values)
            {
                Console.WriteLine($"CD: {cd.Title}");
                cd.DisplaySongs();
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            var catalog = new CDCatalog();

            catalog.AddCD("Inception");
            catalog.AddSong("Inception", "Time");
            catalog.AddSong("Inception", "Dream is Collapsing");

            catalog.AddCD("The Matrix");
            catalog.AddSong("The Matrix", "Clubbed to Death");

            catalog.DisplayCatalog();

            catalog.RemoveSong("Inception", "Time");
            catalog.RemoveCD("The Matrix");

            catalog.DisplayCatalog();
        }
    }
}
