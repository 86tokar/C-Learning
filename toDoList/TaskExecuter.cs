namespace Todos
{
    public class TaskExecutor
    {
        private readonly ITask _task; 
        public TaskExecutor(ITask toDos)
        {
            _task = toDos;
        }
        public void ExecuteTask()
        {
            _task.Execute();
        }
    }
}
