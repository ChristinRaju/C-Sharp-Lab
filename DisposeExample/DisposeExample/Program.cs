using System;
class Program
{
    static void Main()
    {
        using (FileManager fm = new FileManager("test.txt"))
        {
            fm.Write("Hello World!");
        }
    }
}
