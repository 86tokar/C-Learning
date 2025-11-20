using System;
using System.Threading.Channels;

namespace Todos
{
    class Methods
    {
        private static List<string> todoList = new List<string>();
        public static void AddTodoTask()
        {
            var checkTaskDescription = false;
            while (!checkTaskDescription)
            {

                Console.WriteLine("Enter the task description");
                var taskDescription = Console.ReadLine();

                if (taskDescription == "")
                    Console.WriteLine("Description cannot be empty");
                else if (todoList.Contains(taskDescription))
                    Console.WriteLine("The description must be unique");
                else
                {
                    checkTaskDescription = true;
                    todoList.Add(taskDescription);
                }
            }
        }

        public static void SeeTodo()
        {
            if (todoList.Count == 0)
                Console.WriteLine("No TODOs have been added yet");
            else
            {
                for (int i = 0; i < todoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{todoList[i]}");
                }
            }
        }
        public static void RemoveTodo()
        {
            if (todoList.Count == 0)
            {
                ShowNoTasksInTodo();
                return;
            }
            bool validNumberOfTodo = false;
            while (!validNumberOfTodo) 
            {
                Console.WriteLine("Select the index of the TODO you want to remove");
                SeeTodo();
                var numberOfTodoToRemove = Console.ReadLine();
                if (numberOfTodoToRemove == "")
                {
                    Console.WriteLine("Selected index cannot be empty");
                    continue;
                }   
                if (int.TryParse(numberOfTodoToRemove, out int number) && number >= 1 && number <= todoList.Count)
                {
                    var realNumberOfTodoToRemove = todoList[number - 1];
                    todoList.RemoveAt(number - 1);
                    validNumberOfTodo = true;
                    Console.WriteLine($"Todo removed: {realNumberOfTodoToRemove}");
                }
                else
                {
                    Console.WriteLine("The given index is not valid.");
                }
            }
            
        }

        private static void ShowNoTasksInTodo()
        {
            Console.WriteLine("No TODOs have been added yet");
        }
    }
}
