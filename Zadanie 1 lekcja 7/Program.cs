using System;

namespace KatoApp
{

   class Program
    {
        static void Main(string[] args)
        {

            //Nadanie zmiennym int wartości
            int a = 5; 
            int b = 5;

            //Porównanie zmiennych przy użyciu operatora 
            if (a == b)
            {
                Console.WriteLine(a + " i " + b + " są równe ");
            }
            else
            {
                Console.WriteLine(a + " i " + b + " nie są równe ");
            }
        }

    }


}