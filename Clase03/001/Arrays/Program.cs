using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unArray = new int[10];

            for (int i = 0; i < unArray.Length; i++)
            {
                unArray[i] = i;
                Console.WriteLine(unArray[i]);
            }

            List<string> unaLista = new List<string>();
            unaLista.Add("hola");
            unaLista.Remove("hola");
        }
    }
}
