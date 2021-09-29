using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 99; i > 1; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
                Console.WriteLine($"Take one down and pass it around, {i - 1} bottles of beer on the wall.");
                    if (i > 1)
                    {
                        Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
                        Console.WriteLine("Take one and and pass it around, no more bottles of beer on the wall.");
                        Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
                        Console.WriteLine("Go to the store and but some more, 99 bottles of beer on the wall.");
                      
                    }
                }
            }

        }
    }
