using System;

namespace EditFunctions{
    // Returns false if succeed
    // Returns true if failed
    public static bool StringToInt(string str, out int i)
    {
        if (!int.TryParse(str, out i))
        {
            Console.WriteLine("Failed");
            i = 0;
            return true;
        }
        return false;
    }
    public static void SET(string val, out byte by)
    {
        int value;
        if (StringToInt(val, value))
        {
            return;
        }
        by = value;
    }
}