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


            // Declared variables and had to initialize them to a default value so the loops had a something to start with and update the variables as it runs
            int incomeDynamic = 0;
            int incomeStatic = 0;
            int input;
            string expenseName1 = "";
            int expenseAmount1 = 0;

            // Prompt user to enter their income
            Console.Write("\nEnter your monthly income: ");
            // I'm assigning the original input as its own variable and using two different variables depending on users reponse
            int OGincome = int.Parse(Console.ReadLine()); // I declared and initalized for OGincome
            incomeDynamic = OGincome;
            incomeStatic = OGincome;

            // Display menu in a while loop to repeat itself after each input until user decideds to exit
            while (true) 
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1, Add an Expense");
                Console.WriteLine("2. View Expenses and Budget");
                Console.WriteLine("3. Remove an Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                input = int.Parse(Console.ReadLine());

                // Have to nest an if loop because it varies on the users input of which number or any invalid reponse 
                if (input == 1) 
                {
                    Console.Write("\nEnter the expense name: ");
                    expenseName1 = Console.ReadLine().ToLower();
                    Console.Write("Enter the expense amount: ");
                    expenseAmount1 = int.Parse(Console.ReadLine());
                    incomeDynamic -= expenseAmount1; // Update net income 
                    Console.WriteLine("Expense Added Successfully!");
                }
                else if (input == 2)
                {
                    Console.WriteLine("\nExpenses");
                    Console.WriteLine($"- {expenseName1}: ${expenseAmount1}");
                    Console.WriteLine($"Total Expenses: ${expenseAmount1}");
                    Console.WriteLine($"Remaining Budget: ${incomeDynamic}"); // Updated net income displayed here
                }
                else if (input == 3)
                {
                    Console.Write("\nEnter the name of the expense to remove: ");
                    string removeInput = Console.ReadLine().ToLower(); // I Declared and Initialzed removeInput 

                    // Had to nest another if loop because it varies on users reponse
                    if (removeInput == expenseName1) 
                    {
                        expenseName1 = ""; // This resets to an empty space if the user wants to view an expense name in option 2 without having anything added 
                        expenseAmount1 = 0; // This resets the expense to 0 that was correlated to the expense name  
                        incomeDynamic = incomeStatic; // Remaining Budget is reset to original income 
                        Console.WriteLine("Expense removed successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Expense not found, please check the name and try again.");
                    }
                }
                else if(input == 4)
                {
                    Console.WriteLine("\nGoodbye!"); 
                    break; 
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid number.");
                }


            }

            
            
            








        }
    }
}
