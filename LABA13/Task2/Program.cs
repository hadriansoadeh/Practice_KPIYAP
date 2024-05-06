namespace Task2
{
    class Program
    {
        
        delegate void ShowText(String text);

        
        static void CalcualteSum(int a, int b, ShowText myDelegate)
        {
            int result = a + b;

            
            myDelegate(result.ToString());
        }

       
        static void Main(string[] args)
        {
            
            ShowText show = Console.Write;

            
            CalcualteSum(10, 20, show);

           
        }
    }
}
