using System;

namespace Lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Please pick a number 1-100:");
            string userInput1 = Console.ReadLine();
            int x = int.Parse(userInput1);
            Console.WriteLine("Please choose a second number 1-100:");
            string userInput2 = Console.ReadLine();
            int y = int.Parse(userInput2); 

            int userAdd = x + y;
            int userSub = x - y;  
            int userMult = x * y;
            int userDiv = x / y;


            Console.WriteLine("The answer is " + (userAdd)); 
            Console.WriteLine("The answer is " + (userSub));
            Console.WriteLine("The answer is " + (userMult));
            Console.WriteLine("The answer is " + (userDiv));
            Console.WriteLine(); 
            //2
            Console.WriteLine("Please enter your name!");
            string userinput3 = Console.ReadLine();
            Console.WriteLine("Hello " + (userinput3) + "!");
            Console.WriteLine(); 
            //3

            Console.WriteLine("Please enter a number 1-100:");
            string userInput4 = Console.ReadLine();
            int z = int.Parse(userInput4);
            Console.WriteLine("Please enter a second number 1-100:");
            string userInput5 = Console.ReadLine();
            int q = int.Parse(userInput5);
            Console.WriteLine("Please enter a number 1-100:");
            string userInput6 = Console.ReadLine();
            int m  = int.Parse(userInput6);

            int userMult2 = z * q * m;
            Console.WriteLine(userMult2);
            Console.WriteLine();

            //4
            Console.WriteLine("Please enter an age:");
            string userInput7 = Console.ReadLine();
            int n = int.Parse(userInput7);
            int age = n - 20;
            Console.WriteLine("You look younger than " + (age) + " !"); 











        }
    }
}
