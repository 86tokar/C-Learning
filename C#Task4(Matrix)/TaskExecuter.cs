namespace C_Task4_Matrix_
{
    public class TaskExecutor
    {
        private readonly ITask _task; 
        public TaskExecutor(ITask task)
        {
            _task = task;
        }
        public void ExecuteTask()
        {
            _task.Execute();
        }
    }
}
