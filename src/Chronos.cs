/* List of commands:
 * 1. Create new project: new project [name]* [description]
 * 2. Create new task within project: new task [name]* [parent project]* [priority] [description]
 * 3. Start to work on task: start [project name]/[task name]*
 * 4. Edit task/project: ...
 * 5. Delete task/project: ...
 *
 * fields marked with * are required
 * */


namespace Chronos 
{
    class Chronos 
    {
	static void Loop()
	{
		string command = "";
		while (command != "quit" || command != "q")
		{
			command = Console.ReadLine();			
			string[] tokens = command.Split(' ');
			
			if (tokens[0] == "new" && tokens[1] == "project")
			{
				// ...
			}
			else if (tokens[0] == "new" && tokens[1] == "task")
			{
				// ...
			}
		}
	}

        static void Main(string[] args)
        {
		Loop();	
	}
    }
}
