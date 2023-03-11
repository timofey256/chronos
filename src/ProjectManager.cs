namespace Chronos
{

class ProjectManager
{
    private List<Project> _projects = new List<Project>();

    public bool AddTask(Task NewTask, string ProjectName)
    {
        Console.WriteLine("Added a new task!");
        return true;
    }

    public bool RemoveTask(string Name, string ProjectName) 
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

}
