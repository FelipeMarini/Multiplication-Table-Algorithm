using System;

namespace Multiplication_Table_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table");
            Console.WriteLine("Insert a number (integer) to know its multiplication table (from 0 to 10): ");
            int numero = Convert.ToInt16(Console.ReadLine());

            for (int num = 0; num<11; num++)
            {

                int resultado = num*numero;
                Console.WriteLine($"{num} x {numero} = {resultado}");



            }

        }
    }
}
