using System;
using System.Collections.Generic; 
using System.Runtime.InteropServices;
using Output.go;

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
        string[] harray;
        start:
        for (int j = 0; j < data.Length; j++)
        {
            Console.WriteLine($"{j}|{data[j]}");
        }
        harray = ReadArray(Console.ReadLine());
        if (harray[0] == "Console")
        {
            switch (harray.Length)
            {
                case 2:
                    switch (harray[1])
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
                    switch (harray[1])
                    {
                        case "SET":
                            int I;
                            byte O;
                            if (int.TryParse(harray[2], out I))
                            {
                                if (byte.TryParse(harray[3], out O))
                                {
                                    data[I] = O;
                                }
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