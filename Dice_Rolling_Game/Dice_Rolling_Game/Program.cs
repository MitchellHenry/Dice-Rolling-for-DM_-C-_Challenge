using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Rolling_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count2 = 0;
            int Total = 0;
            int count3 = 0;
            int count4 = 0;
            var Results = new List<int>();
            Console.WriteLine("Do you want to roll dice? Yes/No?");
            while (count < 1)
            {
               string Answer = Console.ReadLine();

                if(Answer == "Yes")
                {
                 Random random = new Random();
                 int RandomNumber = random.Next(1, 7);
                    Results.Add(RandomNumber);
                    Total = Total + RandomNumber;
                    count2++;
                    Console.WriteLine(RandomNumber);
                    Console.WriteLine("Roll Again?");
                }
                if (Answer == "No")
                {
                    Console.WriteLine("How many rolls do you want to examine?");
                    while (count3 != 1)
                    {
                        var RollsToExamine = Console.ReadLine();
                        int Number = int.Parse(RollsToExamine);
                        if (Number <= count2 && Number > 0)
                        {
                            count2 = Number;
                            count3 = 1;
                        }
                        if(Number > count2)
                        {
                            Console.WriteLine("The max Number you can examine is " + count2 + "!");
                        }
                        if(Number <= 0)
                        {
                           Console.WriteLine("The Lowest Number you can examine is 1!");
                        }
                        count = 1;
                    }
                }
            }
            int average = Total / count2;
            Console.WriteLine("The Average of the examined numbers is " + average + "!");
            Console.WriteLine("The Total of the examined Rolls is " + Total + "!");
            int count5 = 1;
            while (count4 <= count2 - 1)
                {
                    Console.WriteLine("Roll " + count5 + ": " + Results[count4]);
                    count5++;
                    count4++;
                }
            
            Console.ReadKey(true);
        }
    }
}
