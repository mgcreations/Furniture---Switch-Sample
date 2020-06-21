using System;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            char woodFinish;

            Console.Write("Choose the wood for the table order \n P for Pine, O for Oak or M for Mahogany:");
            woodFinish = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (woodFinish)
            {
                case 'P':
                    Console.WriteLine("Pine tables cost $100");
                    break;
                case 'O':
                    Console.WriteLine("Oak tables cost $225");
                    break;
                case 'M':
                    Console.WriteLine("Mahogany cost $310");
                    break;
                default:
                    Console.WriteLine("Price is $0");
                    break;
            }
        }
    }
}
