using System;

namespace HelloWorldString
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "The two submarines of the U-1 class, U-1 and U-2, were built for the Austro-Hungarian Navy. Constructed according to an American design, they were launched in 1909. A diving chamber, wheels for traveling along the seabed, and other experimental features were tested extensively in sea trials. Their gasoline engines were replaced around the start of World War I over safety and efficiency concerns. The boats have been described by naval historians as obsolete by the time they were commissioned in 1911. Both submarines were mobilized briefly during the Balkan Wars, and otherwise served as training boats before 1915. From 1915 to 1918 they conducted reconnaissance cruises out of Trieste and Pola, though neither sank any enemy vessels during the war. Facing defeat in October 1918, the Austro-Hungarian government transferred the bulk of its fleet, including these submarines, to the newly formed State of Slovenes, Croats and Serbs to avoid having to hand its ships over to the Allied Powers.";

            for(int i = 0; i < helloWorld.Length; i++)
            {
                Console.WriteLine($"kohal {i} on {helloWorld[i]}");
            }
        }
    }
}
