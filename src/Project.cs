/*
Project is a set of tasks you are working on to complete the project.

As long as it shares similar functionality with a Task class itself, it inherites from it. 
*/

namespace Chronos
{

class Project : Task
{
    public Project(string ProjectName) : base (ProjectName) { }

    List<Task> tasks = new List<Task>();

    public void PrintTasks(bool isDetailed = false)
    {
        foreach (Task task in tasks)
        {
            Console.WriteLine($"Name: { task.Name }. Priority: { task.Priority }");
            if (isDetailed)
            {
                Console.WriteLine($"\tDescription: { task.Description }");
                Console.WriteLine($"\tTime spent: { task.TimeSpent }.");
                Console.WriteLine($"\tTime and date of creation: { task.TimeCreated }.");
            }
        }
    }

    public void AddTask(Task NewTask)
    {
        tasks.Add(NewTask);
    } 

    public Task? FindTask(int TaskId) 
    {
        foreach (Task task in tasks) 
        {
            if (task._Id == TaskId)
            {
                return task;
            }
        }

        return null;
    }

    /* Returns 1 if task with Id=TaskId was not found. 0 otherwise*/
    public int UpdateTask(int TaskId, Task task)
    {
        for (int i=0; i<tasks.Count; i++) 
        {
            if (tasks[i]._Id == TaskId)
            {
                tasks[i] = task;
            	// TODO: throw error
	    }
        }   

        return 1;
    }
}

}
