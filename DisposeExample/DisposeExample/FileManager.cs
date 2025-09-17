using System;
using System.IO;

class FileManager : IDisposable
{
    private StreamWriter file;

    public FileManager(string path)
    {
        file = new StreamWriter(path);
        Console.WriteLine("File opened");
        Console.WriteLine("File created at: " + Path.GetFullPath("test.txt"));

    }

    public void Write(string text)
    {
        file.WriteLine(text);
    }

    public void Dispose()
    {
        file.Close();
        Console.WriteLine("File closed");
    }
}

