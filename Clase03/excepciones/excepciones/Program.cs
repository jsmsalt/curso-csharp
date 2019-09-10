using System;

namespace excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = new int[10];
                Console.WriteLine(a[11]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("mal mal");
            }
        }
    }
}
