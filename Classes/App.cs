using InterviewTaskApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTaskApp.Classes
{
    public class App
    {
       
        public void Run()
        {


            TaskController taskController = new TaskController();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== To-Do Console App ====");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Edit Task");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Mark Task as Complete");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        taskController.DisplayTasks();
                        break;
                    case "2":
                        taskController.Add();
                        break;
                    case "3":
                        taskController.Update();
                        break;
                    case "4":
                        taskController.Delete();
                        break;
                    case "5":
                        taskController.CompleteTask();
                        break;
                    case "6":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        Console.ReadLine();
                        break;
                }
            }
        }

 
        
    }
}
