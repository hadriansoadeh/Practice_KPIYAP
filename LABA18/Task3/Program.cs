namespace Task3
{
    public class Prototype<T> where T : ICloneable
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void RemoveItem(T item)
        {
            items.Remove(item);
        }

        public T CloneItem(T item)
        {
            return (T)item.Clone();
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Movie : ICloneable
    {
        public string Title { get; set; }
        public int? Year { get; set; } 

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Название: {Title}, Год: {Year?.ToString() ?? "N/A"}";
        }
    }

    public class Program
    {
        public static void Main()
        {
            var prototype = new Prototype<Movie>();

            var movie1 = new Movie { Title = "Inception", Year = 2010 };
            prototype.AddItem(movie1);

            var movie2 = new Movie { Title = "The Matrix", Year = 1999 };
            prototype.AddItem(movie2);

            var movie3 = prototype.CloneItem(movie1);
            movie3.Title = "Inception Cloned";
            prototype.AddItem(movie3);

            prototype.DisplayItems();
        }
    }
}
