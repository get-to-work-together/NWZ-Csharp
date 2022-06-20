using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;

namespace CSV_to_JSON
{
    class CSV_to_JSON
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"S:\Radiotherapie\Applications\Ontwikkeling_Git\CS - Training\CSV_to_JSON\Contouren_Prostaat.csv"))
            {
                List<List<string>> ListA = new List<List<string>>();
                List<string> ListB = new List<string>();
                while (!reader.EndOfStream)
                {
                    ListB.Clear();
                    var line = reader.ReadLine();
                    var values = line.Split(';');
               
                    foreach(string item in values)
                    {
                        ListB.Add(item);
                    }
                    ListA.Add(ListB);
                }

                ListA.ForEach(Console.WriteLine);

                
                var data_dict = ListA.Zip(ListB, (k, v) => new { k, v }).ToDictionary(x => x.k, x => x.v);

                Console.WriteLine(data_dict);
                data_dict.ToList().ForEach(x => Console.WriteLine(x.Key));


                string json = JsonSerializer.Serialize(data_dict);
                File.WriteAllText(@"S:\Radiotherapie\Applications\Ontwikkeling_Git\CS - Training\CSV_to_JSON\import.json", json);

            }
        }

    }
    
}


