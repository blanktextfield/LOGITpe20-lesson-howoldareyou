using System;

namespace Howoldareyou
{
    class Program
    {
        static void Main(string[] args)
        {
            //App greets the user
            //App asks the user`s name
            //App greets the user by their name
            //App asks the users age
            //app calculates the age of the user
            //the app displays the results (the user`s name)
            Console.WriteLine("Welcome user");
            Console.WriteLine("Please insert users`s name ");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);
            Console.WriteLine("What is users age");
            string Userinput;
            Userinput = Console.ReadLine();
            int YearofBirth;
            //parsing string to interger (number)

            YearofBirth = Int32.Parse(Userinput);
            int Age = 2020 - YearofBirth;
            Console.WriteLine("you are" + Age + "old.");


        }
    }
}
