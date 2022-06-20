using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_ExpandoObject.Models.Invoer
{
    public class CsvParser
    {

        public static List<Dictionary<string, object>> parse(string filename)
        {
            const char SEP = ';';

            List<Dictionary<string, object>> list_of_dicts = new();

            // Eerste regel bevat headers.
            string headerline = File.ReadLines(filename).First();
            var headers = headerline.Split(SEP);

            foreach (string line in File.ReadLines(filename).Skip(1))
            {
                Dictionary<string, object> dict = new();

                var values = line.Split(SEP);

                for (var i = 0; i < headers.Length; i++)
                {
                    var key = headers[i];
                    var value = values[i];
                    dict.Add(key, value);
                }

                list_of_dicts.Add(dict);
            }

            return list_of_dicts;
        }

    }
}
