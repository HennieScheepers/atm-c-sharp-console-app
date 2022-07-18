using System;

namespace ATT_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialization
            String userName = "Hennie Scheepers";
            int userPin = 1234;

            // greeting
            Console.WriteLine("Welcome to the bank of Coding!");
            Console.WriteLine("");
            Console.WriteLine("Press L to login.");
            String loginCheck = Console.ReadLine().ToLower();
            bool isLogin = false;

            //check to see if user has selected L to continue the rest of the program
            while (isLogin == false)
            {

                if (loginCheck == "l")
                {
                    Console.WriteLine("Please enter username: ");
                    Console.WriteLine("");

                    String loginName = Console.ReadLine();
                    Console.WriteLine("Please enter PIN number: ");
                    int loginPin = Convert.ToInt32(Console.ReadLine());

                    //check username and pin values entered by user and compares them to the correct username and pin
                    if (loginName == userName && loginPin == userPin)
                    {
                        isLogin = true;
                        Console.WriteLine("Logged in!");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Wrong username or password!!!");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Press l to login");
                    loginCheck = Console.ReadLine();
                }

            }
        }
    }
}
