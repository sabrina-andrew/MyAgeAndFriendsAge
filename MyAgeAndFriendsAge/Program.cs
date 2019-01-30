using System;

namespace MyAgeAndFriendsAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge;
            string myName;
            int friendsAge;
            string friendsName;
            
            Console.WriteLine("How old are you?");
            myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your name?");
            myName = Console.ReadLine();
            Console.WriteLine("Your name is " + myName + " and you are" + myAge + " years old!");

            Console.WriteLine("How old is your friend?");
            friendsAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your friends name?");
            friendsName = Console.ReadLine();
            Console.WriteLine("Your friends name is " + friendsName + "and they are " + friendsAge + " years old!");

            int oldPeople = myAge + friendsAge;

            Console.WriteLine("You ages added together is " + oldPeople + " years!");

            
        }
    }
}
