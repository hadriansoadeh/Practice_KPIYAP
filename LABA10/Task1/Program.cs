namespace Task1
{
    class Notebook
    {
        private string title;
        private int numPages;

        public Notebook(string title, int numPages)
        {
            this.title = title;
            this.numPages = numPages;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetNumPages(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumPages()
        {
            return numPages;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Notebook Title: " + title);
            Console.WriteLine("Number of Pages: " + numPages);
        }

        public virtual void Cost()
        {
            Console.WriteLine("Cost: 15");
        }
    }

    class SpecialNotebook : Notebook
    {
        private string specialFeature;

        public SpecialNotebook(string title, int numPages, string specialFeature) : base(title, numPages)
        {
            this.specialFeature = specialFeature;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Special Feature: " + specialFeature);
        }
    }

    class Program
    {
        static void Main()
        {
            Notebook notebook1 = new Notebook("Simple Notebook", 100);
            notebook1.DisplayInfo();
            notebook1.Cost();

            Console.WriteLine();

            SpecialNotebook specialNotebook1 = new SpecialNotebook("Special Notebook", 120, "Waterproof");
            specialNotebook1.DisplayInfo();
            specialNotebook1.Cost();
        }
    }
}
