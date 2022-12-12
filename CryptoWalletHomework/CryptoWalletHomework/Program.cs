

using CryptoWalletHomework.Classes.Transactions;

namespace CryptoWalletHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Pri pokretanju aplikacije se kreira 9 predefiniranih
            //walleta te 10 fungible i 20 non fungible asseta.

            

            MainMenu();

        }

        public static void MainMenu()
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine($"******************** <MAIN MENU> ************************");
                Console.WriteLine($"Select an operation:\n" +
                    $"1) Create a wallet\n" +
                    $"2) Access wallet\n" +
                    $"0) Exit app\n");

                bool success;
                success = int.TryParse(Console.ReadLine(), out int userOperationChoice);

                if (success == true)
                {
                    switch (userOperationChoice)
                    {
                        case 0: loop = false; break;
                        case 1:
                            Console.Clear();
                            SubMenuOptionOne();
                            break;
                        case 2:
                            Console.Clear();



                            SubMenuOptionTwo();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine($"Invalid operation number! Enter again.\nTo exit the app enter (zero)\n");
                            break;


                    }
                }
                else
                {
                    Console.Clear(); 
                    Console.WriteLine("Please enter a *number* value.");
                }
            }
            Console.Clear();
            Console.WriteLine("Exited app.");
        }

        public static void SubMenuOptionOne()
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine($"****************** <SUB MENU - Create a wallet> ******************");
                Console.WriteLine($"Select an operation:\n" +
                    $"1) Bitcoin Wallet\n" +
                    $"2) Ethereum wallet\n" +
                    $"3) Solana wallet\n" +
                    $"0) Return to <MAIN MENU>\n");

                bool success;
                success = int.TryParse(Console.ReadLine(), out int userOperationChoice);

                if (success == true)
                {
                    switch (userOperationChoice)
                    {
                        case 0: loop = false; break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("1) Bitcoin Wallet\n" +
                            "--------------------------------------------------");
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("2) Ethereum wallet\n" +
                            "--------------------------------------------------");
                            Console.WriteLine();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("3) Solana wallet\n" +
                            "--------------------------------------------------");
                            Console.WriteLine();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine($"Invalid operation number! Enter again.\nTo exit the app enter (zero)\n");
                            break;


                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a *number* value.");
                }
            }
            Console.Clear();
            Console.WriteLine("Returned to <MAIN MENU>");
        }
       
        public static void SubMenuOptionTwo()
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine($"****************** <SUB MENU - Acces Wallet> ******************");
                Console.WriteLine($"Select an operation:\n" +
                    $"1) Portfolio\n" +
                    $"2) Transfer\n" +
                    $"3) Transaction history\n" +
                    $"4) Transaction withdrawal\n" +
                    $"0) Return to <MAIN MENU>\n");

                bool success;
                success = int.TryParse(Console.ReadLine(), out int userOperationChoice);

                if (success == true)
                {
                    switch (userOperationChoice)
                    {
                        case 0: loop = false; break;
                        case 1:
                            Console.WriteLine("1) Portfolio\n" +
                            "--------------------------------------------------");
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine("2) Access Transfer\n" +
                            "--------------------------------------------------");
                            Console.WriteLine();
                            break;

                        case 3:
                            Console.WriteLine("3) Transaction history\n" +
                            "--------------------------------------------------");
                            Console.WriteLine();
                            break;

                        case 4:
                            Console.WriteLine("4) Transaction withdrawal\n" +
                            "--------------------------------------------------");
                            Console.WriteLine();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine($"Invalid operation number! Enter again.\nTo exit the app enter (zero)\n");
                            break;


                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a *number* value.");
                }
            }
            Console.Clear();
            Console.WriteLine("Returned to <MAIN MENU>");
        }

    }
}