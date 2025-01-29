// Author: Justin Rodriguez 
// Course: COMP-003A 
// Faculty: Jonathan Cruz 
// Purpose: Budget management application demonstrating control flow. 
namespace COMP0003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Budget Management Tool!");

            // Prompt the user to enter their current monthly income
            int income;
            Console.Write("\nEnter your monthly income: ");
            income = int.Parse(Console.ReadLine());

            // Display menu and options 
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add an Expense");
            Console.WriteLine("2. View Expenses and Budget");
            Console.WriteLine("3. Remove and Expense");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice: ");


            


        }
    }
}
