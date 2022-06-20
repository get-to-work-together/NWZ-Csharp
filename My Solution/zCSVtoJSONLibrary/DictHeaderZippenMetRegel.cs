using System;
using System.Collections.Generic;
using System.Linq;

public class DictHeaderZippenMetRegel
{
    public static int counter;
    IDictionary<string, string> dictionary = new Dictionary<string, string>();


    public DictHeaderZippenMetRegel(string[] header, string[] regel)

    {

        //make dictionary key=header, value =cel
        dictionary = header.Zip(regel, (h, c) => new { Key = h, Value = c })
        .ToDictionary(x => x.Key, x => x.Value);

        foreach (var kvp in dictionary)
            Console.Write("Key: {0}, Value:{1}\t", kvp.Key, kvp.Value);
        Console.WriteLine();
    }

    public string this[string key]
    {
        // returns value if exists
        get { return dictionary[key]; }

        // updates if exists, adds if doesn't exist
        set { dictionary[key] = value; }
    }






}

