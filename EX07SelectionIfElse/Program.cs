using System;

namespace EX07SelectionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            //7.1

            /*
            Console.WriteLine("Indtast det beløb du ønsker at handle for");
            double price = double.Parse(Console.ReadLine());
            double discount = 0;

            if (price > 1000)
            {
                discount = price * 0.05;
            }
            Console.WriteLine($"Du får {discount} kr. i rabat!");
            */

            //7.2

            /*
            Console.WriteLine("Indtast det første tal.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast det andet tal.");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("De to tal er ens.");
            }
            else
            {
                Console.WriteLine("De to tal er IKKE ens.");
            }
            */

            //7.3

            /*
            Console.WriteLine("Indtast det første tal.");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast det andet tal.");
            int input2 = int.Parse(Console.ReadLine());

            if (input2 == 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine("Svar: {0}", input1 / input2);
            }
            */

            //7.4

            /*
            Console.WriteLine("Indtast to tal, og jeg skal fortælle hvilket er størst.");
            Console.WriteLine("Indtast et heltal, og afslut med enter.");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast et heltal, og afslut med enter.");
            int input2 = int.Parse(Console.ReadLine());

            if (input1 > input2)
            {
                Console.WriteLine($"Det største tal er {input1}.");
            }
            else if (input2 > input1)
            {
                Console.WriteLine($"Det største tal er {input2}.");
            }
            else
            {
                Console.WriteLine("De to tal er ens.");
            }
            */

            //7.5

            /*
            Console.WriteLine("Indtast to tal, og jeg skal printe dem i stigende order.");
            Console.WriteLine("Indtast nu det første tal:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast nu det andet tal:");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number2);
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number1);
                Console.WriteLine(number2);
            }
            */

            //7.6

            /*
            Console.WriteLine("Indtast et heltal, og jeg skal fortælle om det er positivt, negativt eller 0.");
            Console.WriteLine("Indtast et heltal:");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Tallet er positivt.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Tallet er negativt.");
            }
            else
            {
                Console.WriteLine("Tallet er 0.");
            }
            */

            //7.7

            Console.WriteLine("Indtast hvor meget dit brev vejer i gram.");
            int gram = int.Parse(Console.ReadLine());
            int price;
            
            if (gram < 20)
            {
                price = 5;
            }
            else if (gram >= 20 && gram < 50)
            {
                price = 7;
            }
            else if (gram >= 50 && gram < 100)
            {
                price = 10;
            }
            else if (gram >= 100 && gram < 150)
            {
                price = 15;
            }
            else if (gram >= 150 && gram < 200)
            {
                price = 20;
            }
            else
            {
                price = 30;
            }
            Console.WriteLine($"Din pris er {price}.");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Vil du have expres forsændelse?");
            Console.WriteLine("Det vil koste 50% mere.");
            Console.WriteLine("Tryk > j < for ja, eller > n < for nej.");
            string svar = Console.ReadLine();

            if (svar.Equals("j"))
            {
                Console.WriteLine("");
                Console.WriteLine("Ja");
                Console.WriteLine($"Pris {price * 1.5}.");
            }
            else if (svar.Equals("n"))
            {
                Console.WriteLine("");
                Console.WriteLine("Nej");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("ERROR");
            }
        }
    }
}
