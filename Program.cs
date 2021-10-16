sing System;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {  string name2;
            bool result2;


            Uc2 lastname = new Uc2();
            Console.WriteLine("Enter First Character in Bolt Latters...");
            Console.WriteLine("Enter the Last Name");

            name2 = Console.ReadLine();

            result2 = lastname.LastNameCheck(name2);
            Console.WriteLine(result2);

            
         }
     }
}
