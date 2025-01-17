using InterviewTaskApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTaskApp.Controllers
{
    public class TaskController : ITaskCRUD
    {
        List<Task> tasks = new List<Task>();
        int _id = 1;

        public void Add()
        {
            Console.Clear();
            Console.WriteLine("==== Add a New Task ====");
            Console.Write("Enter task title: ");
            string title = Console.ReadLine();

            tasks.Add(new Task { Id = _id++, Title = title, IsCompleted = false });
            Console.WriteLine("Task added successfully! Press Enter to return to the menu");
            Console.ReadLine();
        }


        public void Delete()
        {
            Console.Clear();
            Console.WriteLine("==== Delete a Task ====");
            Console.Write("Enter Task ID to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var task = tasks.Find(t => t.Id == id);
                if (task != null)
                {
                    tasks.Remove(task);
                    Console.WriteLine("Task deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Task not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadLine();
        }

 



        public void Update()
        {
            Console.Clear();
            Console.WriteLine("==== Edit a Task ====");
            Console.Write("Enter Task ID to edit: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
               Task? task = tasks.Find(t => t.Id == id);
                if (task != null)
                {
                    Console.Write("Enter new title: ");
                    task.Title = Console.ReadLine();
                    Console.WriteLine("Task updated successfully!");
                }
                else
                {
                    Console.WriteLine("Task not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadLine();
        }


        public void DisplayTasks()
        {
            Console.Clear();
            Console.WriteLine("==== To-Do List ====");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available");
            }
            else
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($"{task.Id}. {task.Title} - [{(task.IsCompleted ? "X" : " ")}] ");
                }
            }
            Console.WriteLine("\nPress Enter to return to the menu");
            Console.ReadLine();
        }


        public void CompleteTask()
        {
            Console.Clear();
            Console.WriteLine("==== Mark Task as Complete ====");
            Console.Write("Enter Task ID to mark as complete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var task = tasks.Find(t => t.Id == id);
                if (task != null)
                {
                    task.IsCompleted = true;
                    Console.WriteLine("Task marked as complete! ");
                }
                else
                {
                    Console.WriteLine("Task not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.ReadLine();
        }
    }
}
