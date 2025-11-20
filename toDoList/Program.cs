using Todos;

ITask toDoList = new ToDoList();

TaskExecutor executor = new TaskExecutor(toDoList);
executor.ExecuteTask();