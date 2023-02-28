class TaskManager
{
    public bool AddTask(Task NewTask)
    {
        Console.WriteLine("Added a new task!");
        return true;
    }

    public bool RemoveTask(string Name) 
    {
        return true;
    }

    public bool AddProject(Project NewTask)
    {
        Console.WriteLine("Added a new project!");
        return true;
    }

    public bool RemoveProject(string Name) 
    {
        return true;
    }
}