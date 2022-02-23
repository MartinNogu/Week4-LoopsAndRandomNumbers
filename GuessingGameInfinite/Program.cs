using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud
            //katsete arv on piiramatu
            //*programm genereerib juhuslikku numbrit ühe korra ehk ainult üks number.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (true)
            {
                Console.WriteLine("Palun sisesta number ühest kümneni:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, võitsid mängu!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale number. Proovi uuesti.");
                }


            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
