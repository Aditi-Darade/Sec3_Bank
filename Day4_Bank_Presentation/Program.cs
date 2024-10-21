using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Bank_Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***********************************Bank***********************************");
            System.Console.WriteLine("::Login Page::");

            string username = null, password = null;
            System.Console.WriteLine("Username: ");
            username = System.Console.ReadLine();

            if (username != "")
            {
                System.Console.WriteLine("Password: ");
                password = System.Console.ReadLine();
            }

            if (username == "system" && password == "manager")
            {
                int mainMenuChoice;
                do
                {
                    System.Console.WriteLine(":::::Main Menu:::::");
                    System.Console.WriteLine("1. Customers");
                    System.Console.WriteLine("2. Accounts");
                    System.Console.WriteLine("3. Funds Transfer");
                    System.Console.WriteLine("4. Funds Transfer Statement");
                    System.Console.WriteLine("5. Account Statement");
                    System.Console.WriteLine("0. Exit");

                    System.Console.WriteLine("Enter Choice:");
                    mainMenuChoice = int.Parse(System.Console.ReadLine());

                    switch (mainMenuChoice)
                    {
                        case 1:
                            CustomersMenu();
                            break;
                        case 2:
                            AccountsMenu();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }

                } while (mainMenuChoice != 0);

            }

            System.Console.WriteLine("Thank You!!! Visit Again.");
            System.Console.ReadKey();
        }

        static void CustomersMenu()
        {
            int CustomerMenuChoice;

            do
            {
                System.Console.WriteLine(":::::Customers Menu:::::");
                System.Console.WriteLine("1. Add Customer");
                System.Console.WriteLine("2. Delete Customer");
                System.Console.WriteLine("3. Update Customer");
                System.Console.WriteLine("4. View Customer");
                System.Console.WriteLine("0. Back to Main Menu");

                System.Console.WriteLine("Enter Choice:");
                CustomerMenuChoice = int.Parse(System.Console.ReadLine());
            }
            while (CustomerMenuChoice != 0);
        }
        static void AccountsMenu()
        {
            int AccountMenuChoice;

            do
            {
                System.Console.WriteLine(":::::Accounts Menu:::::");
                System.Console.WriteLine("1. Add Account");
                System.Console.WriteLine("2. Delete Account");
                System.Console.WriteLine("3. Update Account");
                System.Console.WriteLine("4. View Account");
                System.Console.WriteLine("0. Back to Main Menu");

                System.Console.WriteLine("Enter Choice:");
                AccountMenuChoice = int.Parse(System.Console.ReadLine());
            }
            while (AccountMenuChoice != 0);
        }
    }
}
