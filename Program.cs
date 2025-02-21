using System;
using Delegate_and_Reflection;

public delegate void PrintMessage(string message);
public class Program
{
    public static void PrintToConsole(string message)
    {
        Console.WriteLine(message);
    }
    public static void PrintToFile(string message)
    {
        Console.WriteLine("File: "+message);
    }
    public static void Main(string[] args)
    {
        //PrintMessage printMessage = new PrintMessage(PrintToConsole);
        //printMessage("Hello, World!");
        //PrintMessage printMessageDel = PrintToConsole;
        //printMessageDel += PrintToFile;

        //printMessageDel("Hello, Multicast!");
        ConsoleMenuSystem.Show();
    }
}
