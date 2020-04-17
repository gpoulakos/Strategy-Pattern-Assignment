using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment
{
    class Program
    {
        private static int Menu(int addtocart)
        {
            bool keepBuying = true;

            do
            {
                Console.WriteLine("Choose your color: \r\n" +
               "[1] Red, [2] Orange, [3] Yellow, [4] Green, [5] Blue, [6] Indigo, [7] Violet");
                var color = Console.ReadLine();

                switch (color)
                {
                    case "1":
                        addtocart += (int)Color.RED;
                        break;
                    case "2":
                        addtocart += (int)Color.ORANGE;
                        break;
                    case "3":
                        addtocart += (int)Color.YELLOW;
                        break;
                    case "4":
                        addtocart += (int)Color.GREEN;
                        break;
                    case "5":
                        addtocart += (int)Color.BLUE;
                        break;
                    case "6":
                        addtocart += (int)Color.INDIGO;
                        break;
                    case "7":
                        addtocart += (int)Color.VIOLET;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Please try again!");
                        break;
                }
                Console.WriteLine("============================================");

                Console.WriteLine("Choose your size : \r\n" +
                   "[1] XS, [2] S, [3] M, [4] L, [5] XL, [6] XXL, [7] XXXL");
                var size = Console.ReadLine();

                switch (size)
                {
                    case "1":
                        addtocart += (int)Size.XS;
                        break;
                    case "2":
                        addtocart += (int)Size.S;
                        break;
                    case "3":
                        addtocart += (int)Size.M;
                        break;
                    case "4":
                        addtocart += (int)Size.L;
                        break;
                    case "5":
                        addtocart += (int)Size.XL;
                        break;
                    case "6":
                        addtocart += (int)Size.XXL;
                        break;
                    case "7":
                        addtocart += (int)Size.XXXL;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Please try again!");
                        break;
                }
                Console.WriteLine("============================================");

                Console.WriteLine("Choose a fabric : \r\n" +
                    "[1] Wool, [2] Cotton, [3] Polyester, [4] Rayon, [5] Linen, [6] Cashmere, [7] Silk");
                var fabric = Console.ReadLine();

                switch (fabric)
                {
                    case "1":
                        addtocart += (int)Fabric.WOOL;
                        break;
                    case "2":
                        addtocart += (int)Fabric.COTTON;
                        break;
                    case "3":
                        addtocart += (int)Fabric.POLYESTER;
                        break;
                    case "4":
                        addtocart += (int)Fabric.RAYON;
                        break;
                    case "5":
                        addtocart += (int)Fabric.LINEN;
                        break;
                    case "6":
                        addtocart += (int)Fabric.CASHMERE;
                        break;
                    case "7":
                        addtocart += (int)Fabric.SILK;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Please try again!");
                        break;
                }
                Console.WriteLine("============================================");

                Console.WriteLine("Do you want to continue purchasing T-Shirts? Y/N");
                string answer = Console.ReadLine();
                if (answer == "N" || answer == "n")
                    break;

            } while (keepBuying);
            return addtocart;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our E-Shop!");

            int addtocart = 0;
            PaymentProcedure paymentProcedure = new PaymentProcedure();

            addtocart = Menu(addtocart);

            Console.WriteLine("Based on your purchase, proceed to payment via:");

            if (addtocart == 0 || addtocart < 50)
            {
                paymentProcedure.SetPaymentMethod(new Cash());

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Cash");
            }
            else if (addtocart >= 50 || addtocart <= 100)
            {
                paymentProcedure.SetPaymentMethod(new BankTransfer());

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Bank Transfer");
            }
            else
            {
                paymentProcedure.SetPaymentMethod(new CreditorDebitCard());

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Credit or Debit Card");
            }

            paymentProcedure.Price(addtocart);


            Console.ReadKey();
        }
    }
}


