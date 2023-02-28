public class Task 
{
    public Task() {}

    public Task(string TaskName)
    {
        Name = TaskName;
    }
    
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? TimeSpent { get; set; }
    public string? TimeCreated { get; set; }
}