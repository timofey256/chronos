namespace Chronos
{

public class Task 
{
    public Task(string taskName,
		string desc = "",
		int priority = -1)
    {
        Random rnd = new Random();
        _Id = rnd.Next(1000, 9999);
        Name = taskName;
        Description = desc;
        TimeCreated = DateTime.Now;
        TimeSpent = 0;
        Priority = priority;
    }

    public int _Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int TimeSpent { get; set; } // In minutes
    public DateTime TimeCreated { get; set; }
    public int Priority { get; set; }

    public void Print(bool isDetailed = false)
    {
    	if (isDetailed) 
	{
		Console.Write($"{_Id} "); 
	}
    	Console.Write($"{Name}. \n");
	Console.WriteLine($"Time spent: {TimeSpent} min");
	if (isDetailed) 
    	{
		Console.WriteLine($"Description: {Description}");
		Console.WriteLine($"Time of creation: {TimeCreated}");
	}
    }  
}

}
