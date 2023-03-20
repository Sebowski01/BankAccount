using System;


namespace BankAccount
{
    class Program
    {
        static void Main() {

            

            Console.WriteLine("Sparkassen Danmark, hvad kan vi gøre for dig");
            Console.WriteLine("--------------------------------------------");
            
            Account obj = new Account(10000);

            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            bool knownKeyPressed = false;
           

            do
            {
                ConsoleKeyInfo keyReaded = Console.ReadKey();
                switch (keyReaded.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        obj.DisplayMessege();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("How much?");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        obj.Withdraw(amount);
                        obj.DisplayMessege();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("How much?");
                        int amount2 = Convert.ToInt32(Console.ReadLine());
                        obj.Deposite(amount2);
                        obj.DisplayMessege();
                        break;

                }
            } while (!knownKeyPressed);

           


        }
    }
}