using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får flera försök.");
            Console.WriteLine("Välj svårighetsnivå:\n1. Enkel nivå ( mellan 1-10, 6 försök)\n2. Medel nivå (mellan 1-25, 5 försök)\n3. Svår nivå (mellan 1-50, 3 försök)");
            Console.Write("Ange svårighetsgrad (1-3): ");
            int grade = int.Parse(Console.ReadLine());

            int maxNumb = grade == 1 ? 10 : grade == 2 ? 25 : 50;
            int maxAt = grade == 1 ? 6 : grade == 2 ? 5 : 3;

            Console.WriteLine($"Jag har ett nummer mellan 1 och {maxNumb}. Du har {maxAt} försök!");

            Random random = new Random();
            int numberToGuess = random.Next(1, maxNumb + 1);
            int userAttempts = 0;

            while (userAttempts < maxAt)
            {
                Console.Write("Gissa ett nummer: ");
                int guess = int.Parse(Console.ReadLine());
                userAttempts++;

                if (guess == numberToGuess)
                {
                    Console.WriteLine("Du klarade det!");
                    return;
                }
                else
                {
                    Console.WriteLine(guess < numberToGuess ? "Tyvärr, det är för lågt!" : "Tyvärr, det är för högt!");
                }
            }

            Console.WriteLine($"Tyvärr, du lyckades inte gissa ett nummer på {maxAt} försök! Det rätt nummer är {numberToGuess}.");
        }


    }
   
}
