using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public string UserName { get; set; }
        private string Password { get; set; }

        public void Deposit(double amount)
        {
            _balance += amount;
        }
        
        public double GetBalance() 
        { 
            return _balance; 
        }

        public void MakePassword() 
        {
            Console.Write("Please create a password: ");
            Password = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your password has been submitted.");
            Console.WriteLine();
        }

        public void Credentials() 
        {
            int maxAttempts = 3;
            int attempts = 0;
            while (attempts < maxAttempts)
            {
                Console.Write("Please enter your user name. ");
                var userName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Please enter your password. ");
                var password = Console.ReadLine();
                Console.WriteLine();

                if (userName == UserName && password == Password)
                {
                    Console.WriteLine("You have successfully logged in.");
                    Console.WriteLine();
                    WhatToDo();
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong user name or password.");
                    Console.WriteLine();
                    attempts++;
                }
            }
            if (attempts == maxAttempts)
            {
                Console.WriteLine("Access Denied.");
                
            }
        }

        public void WhatToDo()
        {
            Console.Write("Press \'1\' to view your account balance:\nPress \'2\' to add funds to your account: ");
            Console.WriteLine();
            var input = Console.ReadLine();
            Console.WriteLine();
            
            if (input == "2") 
            {
                Console.WriteLine("How much are you depositing today?");
                Console.WriteLine();
                bool numberEnter = double.TryParse(Console.ReadLine(), out double deposit);
                Console.WriteLine();

                if (numberEnter == true) 
                {
                    Deposit(deposit);
                    Console.WriteLine($"Thank you for your deposit of ${deposit}.");
                    Console.WriteLine();
                    Console.WriteLine($"Account Balance = ${GetBalance()}");
                    Console.WriteLine();
                    Done();
                }

                else 
                {
                    while (!numberEnter) 
                    {
                        Console.WriteLine("Please enter a valid dollar amount.");
                        Console.WriteLine();
                        numberEnter = double.TryParse(Console.ReadLine(), out deposit);
                        if (numberEnter == true) 
                        {
                            Deposit(deposit);
                            Console.WriteLine($"Thank you for your deposit of ${deposit}.");
                            Console.WriteLine();
                            Console.WriteLine($"Account Balance = ${GetBalance()}");
                            Console.WriteLine();
                            Done();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"Account Balance = ${GetBalance()}");
                Console.WriteLine();
                Done();
            }
        }

        public void Done()
        {
            Console.WriteLine("Is that all for you today?\nType \'yes\' if finished or \'no\' for another transaction.");
            Console.WriteLine();
            string answer = Console.ReadLine().ToLower();

            if (answer == "no") 
            {
                WhatToDo();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
            }
        }

    }

}
