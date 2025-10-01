using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, int> GetFrequency(string c)
    {
        var freq = new Dictionary<char, int>();

        foreach (char f in c.ToLower())
        {
            if (f == ' ' || f == ',')
                continue;

            if (freq.ContainsKey(f))
                freq[f]++;
            else
                freq[f] = 1;
        }

        return freq;
    }
    
    static void Main()
    {
        Console.Write("Enter string: ");
        string c = Console.ReadLine();

        var result = GetFrequency(c);

        foreach (var item in result)
        {
            Console.WriteLine(item.Key + "=" + item.Value);
        }

        Console.ReadKey();
    }
}
