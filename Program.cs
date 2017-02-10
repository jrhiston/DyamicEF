using System;

namespace efexample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                var entry = context.Entry(context.Tables["News"]);

                
            }

            Console.WriteLine("Hello World!");
        }
    }
}
