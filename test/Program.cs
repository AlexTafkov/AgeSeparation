using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hello = "Hello";
            Console.WriteLine("Welcome in our age separetion test!");
            Console.WriteLine("Here we are separeting the kid, teen, grown and old pat of the society");
            Console.WriteLine("To begin the test please type your name");

            string yourname;
            yourname = Console.ReadLine();

            Console.WriteLine(Hello + " " + yourname);


            Console.WriteLine("Do you want to countinue " + yourname +"?");

            string yes = "yes";
            

            Console.WriteLine("type 'yes' or else the test is over");

            if (yes == Console.ReadLine())
            {
                
                Console.WriteLine("Alright then");
                Console.WriteLine("How old are you?");

                int age;

                age = Convert.ToInt32(Console.ReadLine());

                int A; A = 12;
                int B; B = 18;
                int C; C = 60;

                if (age <= A)
                {
                    Console.WriteLine("So you're a kid");
                }
                if (age > A && age <= B)
                {
                    Console.WriteLine("So you're a teenager");
                }
                if (age > B && age <= C)
                {
                    Console.WriteLine("So you're a grown person!");
                }
                if (age > C)
                {
                    Console.WriteLine("So you're an old person!!");
                }
                Console.WriteLine("That was it, thank you fort the participation in our test!");
                Console.WriteLine("Have a nice day!");
            }

            else 
            {
                Console.WriteLine("Test is over");
            }
                    
                 
                
            
        }
    }
}
