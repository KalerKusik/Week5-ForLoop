using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada numbrit
            //programm kuvab korrutus tabelit 1 kuni 10 siestatud numbri jaoks
            // 1 * userNumber = 5
            Console.WriteLine("Insert number:");
            int userNumber = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} * {userNumber} = {i * userNumber}");
            }
        }
    }
}
