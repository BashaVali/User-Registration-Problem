using System;
namespace UserRegistrationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserRegistration user = new UserRegistration();
            Console.WriteLine("Welcome to User Registration Problem Statements.");
            bool choice = true;
            while (choice)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1. Enter First Name \n2. Enter Last Name \n3. Exit");
                int condition = Convert.ToInt32(Console.ReadLine());
                switch (condition)
                {
                    case 1:
                        Console.WriteLine("Enter First Name - ");
                        user.FirstName();
                        break;
                    case 2:
                        Console.WriteLine("Enter SurnameLast Name - ");
                        user.LastName();
                        break;
                    default:
                        Console.WriteLine("Oops,Try Again!");
                        choice = false;
                        break;
                }
            }
        }
    }
}
