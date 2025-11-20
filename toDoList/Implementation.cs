namespace Todos
{
    public class ToDoList : ITask
    {
        public void Execute()
        {
            var exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine("Hello!\nWhat do you want to do?\n[S]ee all todos\n[A]dd a todo\n[R]emove a todo\n[E]xit");

                var selectedOptions = Console.ReadLine();

                switch (selectedOptions)
                {
                    case "S":
                    case "s":
                        Methods.SeeTodo();
                        break;
                    case "A":
                    case "a":
                        Methods.AddTodoTask();
                        break;
                    case "R":
                    case "r":
                        Methods.RemoveTodo();
                        break;
                    case "E":
                    case "e":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
