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
            string expenseNameNew = "";
            string expenseName1 = "";
            string expenseName2 = "";
            string expenseName3 = "";
            string expenseName4 = "";
            string expenseName5 = "";
            int expenseAmountNew = 0;
            int expenseAmount1 = 0;
            int expenseAmount2 = 0;
            int expenseAmount3 = 0;
            int expenseAmount4 = 0;
            int expenseAmount5 = 0;

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
                    expenseNameNew = Console.ReadLine().ToLower();
                    Console.Write("Enter the expense amount: ");
                    expenseAmountNew = int.Parse(Console.ReadLine());

                    if (expenseName1 == "")
                    {
                        expenseName1 = expenseNameNew;
                        expenseAmount1 = expenseAmountNew;
                        Console.WriteLine("Expense Added Successfully!");
                    }
                    else if (expenseName2 == "")
                    {
                        expenseName2 = expenseNameNew;
                        expenseAmount2 = expenseAmountNew;
                        Console.WriteLine("Expense Added Successfully!");
                    }
                    else if (expenseName3 == "")
                    {
                        expenseName3 = expenseNameNew;
                        expenseAmount3 = expenseAmountNew;
                        Console.WriteLine("Expense Added Successfully!");
                    }
                    else if (expenseName4 == "")
                    {
                        expenseName4 = expenseNameNew;
                        expenseAmount4 = expenseAmountNew;
                        Console.WriteLine("Expense Added Successfully!");
                    }
                    else if (expenseName5 == "")
                    {
                        expenseName5 = expenseNameNew;
                        expenseAmount5 = expenseAmountNew;
                        Console.WriteLine("Expense Added Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Expense slots are full.");
                    }
                    incomeDynamic -= expenseAmountNew; // Update net income 
                }
                else if (input == 2)
                {
                    Console.WriteLine("\nExpenses");
                    
                    //The power of PEMDAS! I could of made a seperate variable to update each total expense and the remaining budget but I found this to be quicker
                    if (expenseName1 != "")
                    {
                        Console.WriteLine($"- {expenseName1}: ${expenseAmount1}");
                        Console.WriteLine($"Total Expenses: ${expenseAmount1}");
                        Console.WriteLine($"Remaining Budget: ${incomeStatic - expenseAmount1} "); 
                    }
                    if (expenseName2 != "")
                    {
                        Console.WriteLine($"\n- {expenseName2}: ${expenseAmount2}");
                        Console.WriteLine($"Total Expenses: ${expenseAmount2 + expenseAmount1}");
                        Console.WriteLine($"Remaining Budget: ${incomeStatic - expenseAmount1 - expenseAmount2}");
                    }
                    if (expenseName3 != "")
                    {
                        Console.WriteLine($"\n- {expenseName3}: ${expenseAmount3}");
                        Console.WriteLine($"Total Expenses: ${expenseAmount3 + expenseAmount2 + expenseAmount1}");
                        Console.WriteLine($"Remaining Budget: ${incomeStatic - expenseAmount1 - expenseAmount2 - expenseAmount3}");
                    }
                    if (expenseName4 != "")
                    {
                        Console.WriteLine($"\n- {expenseName4}: ${expenseAmount4}");
                        Console.WriteLine($"Total Expenses: ${expenseAmount4 + expenseAmount3 + expenseAmount2 + expenseAmount1}");
                        Console.WriteLine($"Remaining Budget: ${incomeStatic - expenseAmount1 - expenseAmount2 - expenseAmount3 - expenseAmount4}");
                    }
                    if (expenseName5 != "")
                    {
                        Console.WriteLine($"\n- {expenseName5}: ${expenseAmount5}");
                        Console.WriteLine($"Total Expenses: ${expenseAmount5 + expenseAmount4 + expenseAmount3 + expenseAmount2 + expenseAmount1}");
                        Console.WriteLine($"Remaining Budget: ${incomeStatic - expenseAmount1 - expenseAmount2 - expenseAmount3 - expenseAmount4 - expenseAmount5}");
                    }
                    
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
                    else if (removeInput == expenseName2)
                    {
                        expenseName2 = "";
                        expenseAmount2 = 0;

                    }
                    else
                    {
                        Console.WriteLine("Expense not found, please check the name and try again.");
                    }
                }
                else if (input == 4)
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
