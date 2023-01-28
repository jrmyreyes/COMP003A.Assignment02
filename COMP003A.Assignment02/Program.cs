/*
 * Author:  Ron Jeremy Reyes
 * Course: COMP-003A
 * Purpose: Assignment for week  2
 */
namespace COMP003A.Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console Section */
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("**************************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("**************************************************");
            Console.WriteLine("");
            Console.WriteLine("");

            /* String Section */
            Console.WriteLine("**************************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("**************************************************");

            Console.Write("Enter First Name: "); // First Name
            string firstName = Console.ReadLine();
            Console.Write("Enter Middle Name: "); // Middle Name
            string middleName = Console.ReadLine();
            Console.Write("Enter Last Name: "); // Last Name
            string lastName = Console.ReadLine();
            Console.Write("Enter Age in 2023: "); // Age
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. Your were born in {yearBorn}");
            Console.WriteLine("");
            Console.WriteLine("");

            /* Math Section */
            Console.WriteLine("**************************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("**************************************************");

            Console.Write("Enter an integer for interger1: ");
            string int_1 = Console.ReadLine();
            int integer1 = Convert.ToInt32(int_1);
            Console.Write("Enter an integer for integer2: ");
            string int_2 = Console.ReadLine();
            int integer2 = Convert.ToInt32(int_2);
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}"); // addition
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}"); // substraction
            Console.WriteLine($"{integer1} * {integer2}  = {integer1 * integer2}"); // multiplication
            Console.WriteLine($"{integer1} / {integer2}  = {integer1 / integer2}"); // division
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}"); // remainder
            Console.WriteLine("");
            Console.WriteLine("");

            /* Circle Area & Circumference Calculator Section */
            Console.WriteLine("**************************************************");
            Console.WriteLine("Circle Area & Circumference Calculator Section");
            Console.WriteLine("**************************************************");

            Console.Write("Enter radius: ");
            string rad = Console.ReadLine();
            double radius = Convert.ToDouble(rad);
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The area is {area}");
            Console.WriteLine($"The circumference is {circumference}");

        }
    }
}