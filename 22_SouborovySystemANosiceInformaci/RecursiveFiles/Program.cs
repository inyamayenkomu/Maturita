namespace RecursiveFiles;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = args.Length > 0 ? args[0] : Directory.GetCurrentDirectory();
        WriteDirectory(path, 0);
    }

    static void WriteDirectory(string DirectoryPath, int indentValue)
    {
        string indent = new string(' ', indentValue*2);
        Console.WriteLine($"{indent}{Path.GetFileName(DirectoryPath)}");

        foreach(string file in Directory.EnumerateFiles(DirectoryPath))
        {
            Console.WriteLine($"{indent}  {Path.GetFileName(file)}");
        }
        foreach(string directory in Directory.EnumerateDirectories(DirectoryPath))
        {
            WriteDirectory(directory, indentValue+1);
        }
    }
}
