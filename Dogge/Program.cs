class Program
{
    public static void Main()
    {
        ConsoleWorker.WriteAt(@"D:/Dog.csv");
    }
}

class ConsoleWorker
{
    public static void WriteAt(string path)
    {
        int x = Console.CursorTop;
        int y = Console.CursorLeft;
        bool tailRelease = false;
        var file = FileWorker.FileReader(path);
        for (int i = 0; i < file.Length; i++)
        {
            switch (file[i])
            {
                case "Right":
                    Console.SetCursorPosition(x++, y);
                    if(tailRelease == true)
                    {
                        Console.Write("█");
                    }
                    break;
                case "Left":
                    Console.SetCursorPosition(x--, y);
                    if (tailRelease == true)
                    {
                        Console.Write("█");
                    }
                    break;
                case "Up":
                    Console.SetCursorPosition(x, y--);
                    if (tailRelease == true)
                    {
                        Console.Write("█");
                    }
                    break;
                case "Down":
                    Console.SetCursorPosition(x, y++);
                    if (tailRelease == true)
                    {
                        Console.Write("█");
                    }
                    break;
                case "TailRelease":
                    tailRelease = false;
                    break;
                case "TailRaise":
                    tailRelease = true;
                    break;
            }
        }
        Console.ReadKey();
    }
}

class FileWorker
{
    public static string[] FileReader(string path)
    {
        string[] file = File.ReadAllLines(path);
        return file;
    }
}