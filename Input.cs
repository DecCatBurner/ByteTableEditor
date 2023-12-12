using System;
using System.Collections.Generic; 
using System.Runtime.InteropServices;
using Output.go;
using EditFunctions;

public class ArrayInput
{
    public static string[] ReadArray(string input)
    {
    List<string> puts = new List<string>();
    string current = "";
    foreach (char put in input)
    {
        if (put == ' ')
        {
            puts.Add(current);
            current = "";
            continue;
        }
        current += put;
    }
    puts.Add(current);
    return puts.ToArray();
    }
    
    public static void Main(string[] args)
    {
        byte[] data = new byte[5];
        string[] inputs;
        start:
        for (int j = 0; j < data.Length; j++)
        {
            Console.WriteLine($"{j}|{data[j]}");
        }
        inputs = ReadArray(Console.ReadLine());
        if (inputs[0] == "Console")
        {
            switch (inputs.Length)
            {
                case 2:
                    switch (inputs[1])
                    {
                        case "?":
                            Console.WriteLine("____Operations____");
                            break;
                        case "Exit":
                            goto exit;
                        default:
                            break;
                    }
                    break;
                case 4:
                    int i;
                    switch (inputs[1])
                    {
                        case "SET":
                            if (!EditFunctions.StringToInt(inputs[2], out i))
                            {
                                EditFunctions.SET(inputs[3], data[i]);
                            }
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Not an excepted command. Type \"Console Help\" for help");
                    break;
            }
        }
        goto start;
        exit:
        Console.WriteLine("OFF");
    }
}