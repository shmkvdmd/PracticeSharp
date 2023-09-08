using System.Text;
using static System.Console;

var commands = new string[] { "push Привет! Это снова я! Пока!",
                "pop 5",
                "push Как твои успехи? Плохо?",
                "push qwertyuiop",
                "push 1234567890",
                "pop 26" };

WriteLine($"\"{ApplyCommands(commands)}\"");

string ApplyCommands(string[] commands)
{
    var builder = new StringBuilder();
    foreach (string command in commands)
    {
        string arg = command.Substring(0, command.IndexOf(' '));
        if (arg == "push")
            builder.Append(command.Substring(command.IndexOf(' ') + 1));
        else if (arg == "pop")
            builder.Remove(builder.Length - Convert.ToInt32(command.Substring(command.IndexOf(' '))), Convert.ToInt32(command.Substring(command.IndexOf(' '))));

    }
    return null;
}