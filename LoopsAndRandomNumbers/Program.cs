using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada PIN-kood
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!"
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti"
            //kasutajal on 3 katset. i < 3

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Palun sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //i = i + 1 == i++
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }
              
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
