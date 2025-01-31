// Author: Justin Rodriguez 
// Course: COMP-003A 
// Faculty: Jonathan Cruz 
// Purpose: Budget management application demonstrating control flow. 
using System.ComponentModel.Design;

namespace COMP0003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Budget Management Tool!");


            // Initialize variables
            int income = 0;
            int input;
            string expenseName1 = "";
            int expenseAmount1 = 0;

            // Prompt user to enter their income
            Console.Write("\nEnter your monthly income: ");
            income = int.Parse(Console.ReadLine());

            // Display menu  
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1, Add an Expense");
                Console.WriteLine("2. View Expenses and Budget");
                Console.WriteLine("3. Remove an Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Write("\nEnter the expense name: ");
                    expenseName1 = Console.ReadLine();
                    Console.Write("Enter the expense amount: ");
                    expenseAmount1 = int.Parse(Console.ReadLine());
                    income -= expenseAmount1; // Update net income 
                    Console.WriteLine("Expense Added Successfully!");
                }
              else if (input == 2)
                {
                    Console.WriteLine("\nExpenses");
                    Console.WriteLine($"- {expenseName1}: ${expenseAmount1}");
                    Console.WriteLine($"Total Expenses: ${expenseAmount1}");
                    Console.WriteLine($"Remaining Budget: ${income}");
                }



            }

            
            
            








        }
    }
}
