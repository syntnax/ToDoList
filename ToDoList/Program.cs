using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the to do list program");
        List<string> Tasklist = new List<string>();
        string option = "";
        
        while (option !="e")
        {
            Console.WriteLine("What would you like to do");
            Console.WriteLine("Enter 1 to add a task to the list");
            Console.WriteLine("Enter 2 to remove a task from the list");
            Console.WriteLine("Enter 3 to view the list");
            Console.WriteLine("Enter e to exit the program");
            
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Please enter the name of task to add to the list");
                string task = Console.ReadLine();
                Tasklist.Add(task);
                Console.WriteLine("Task added to the list");
            }
            else if (option == "2")
            {
                for (int i = 0; i < Tasklist.Count; i++) 
                {
                   Console.WriteLine(i + " :" + Tasklist[i]);
                }
                Console.WriteLine("Please enter the number of the task to remove from the list");
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                Tasklist.RemoveAt(taskNumber);
            }
            else if (option == "3")
            {
                Console.WriteLine("Current task in the list");
                for (int i = 0;i < Tasklist.Count; i++) 
                {
                    Console.WriteLine(Tasklist[i]);
                }
            }
            else if (option == "e")
            {
                Console.WriteLine("exiting program");
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again ");
            }
            Console.WriteLine("Thank you for using the app");
        }

    }
}