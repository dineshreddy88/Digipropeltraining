/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
            string first = ("Digipropel");
            string last = (" India Pvt Limited");
            string Concat = (first + "" + last);

            Console.WriteLine("This is the Bot");
            Console.WriteLine(Concat);

            Console.WriteLine("Enter first name");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastname = Console.ReadLine();

            string concatname = (firstname + " " + lastname);

            Console.WriteLine("enter Age");
            int age = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Your name is" + " " + concatname);
            Console.WriteLine("Your Age is" + " " + age);
  }
}