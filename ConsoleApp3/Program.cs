namespace ConsoleApp3
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //}
        public class GFG
        {
            //Generics method
            public void Display<Z>(string msg, Z value)
            {
                Console.WriteLine("{0}:{1}", msg, value);
            }
            // Driver class
            public class Example
            {

                // Main Method
                public static int Main()
                {

                    // creating object of class GFG
                    GFG p = new GFG();

                    // calling Generics method
                    p.Display<int>("Integer", 122);
                    p.Display<char>("Character", 'H');
                    p.Display<double>("Decimal", 255.67);
                    return 0;
                }
            }
        }
    }
}