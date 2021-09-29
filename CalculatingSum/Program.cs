using System;

namespace CalculatingSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kolm arvu
            //programm kuvab nende arvude summat
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insert Number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                sum = sum + userInput;
            }

            Console.WriteLine($"Result: {sum}");
        }
    }
}
