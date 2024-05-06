namespace Task3
{
    class MyInfo
    {
        private string name;

        

        public event EventHandler NameChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnNameChanged();
                }
            }
        }

        
       

        protected virtual void OnNameChanged()
        {
            NameChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main()
        {
            MyInfo info = new MyInfo();
            info.Name = "Егор";
            string oldName = info.Name;

            info.NameChanged += (sender, e) =>
            {

                Console.WriteLine("Имя " + oldName + " было изменено на " + ((MyInfo)sender).Name);
            };

            info.Name = "Афанасий";
        }
    }
}
