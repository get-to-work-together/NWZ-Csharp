using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace CSVtoJSONLibrary
{

    public class CSVtoJSON
    {
        JsonWriter jw;

        public CSVtoJSON()
        {
            StreamWriter logFile = File.CreateText("jsonlog.json");
            jw = new JsonTextWriter(logFile);
            jw.Formatting = Formatting.Indented;
            jw.WriteStartObject();
            jw.WritePropertyName("prescriptions");
            jw.WriteStartArray();
            jw.WriteStartObject();

            jw.WritePropertyName("prescription");
            jw.WriteStartObject();
        }


        public void DoCSVintoListOfDict(string fileName)
        {
            if (File.Exists(fileName))
            {
                //header in list
                var header = File.ReadAllLines(fileName)[0].Split(';');

                //remove header from lines
                string[] lines = File.ReadAllLines(fileName).Skip(1).ToArray();

                //per regel splitten bij ;
                List<DictHeaderZippenMetRegel> DoseGoalList = new List<DictHeaderZippenMetRegel>();
                foreach (string line in lines)
                {
                    var regel = line.Split(';');
                    DoseGoalList.Add(new DictHeaderZippenMetRegel(header, regel));
                }

                //voor unique items in a list (HashSet) zo kan ik langs deze items loopen
                HashSet<string> uniqueStructureName = new HashSet<string>();
                foreach (DictHeaderZippenMetRegel doseGoal in DoseGoalList)
                {
                    uniqueStructureName.Add(doseGoal["structureName"]);
                }

                //unique items in list
                foreach (string structureName in uniqueStructureName)
                {
                    jw.WritePropertyName("structureName");
                    jw.WriteValue(structureName);
                    jw.WritePropertyName("doseGoals");
                    jw.WriteStartArray();

                    //voor elke dosegoal worden de gegevens weggeschreven in de JSON file
                    foreach (DictHeaderZippenMetRegel doseGoal in DoseGoalList)
                    {
                        if (structureName == doseGoal["structureName"])
                        {
                            string doseGoalType = doseGoal["doseGoalType"];
                            string sign = doseGoal["sign"];
                            double doseCriteria = Convert.ToDouble(doseGoal["doseCriteria"]);
                            string unit = doseGoal["unit"];
                            int tolerance = Convert.ToInt32(doseGoal["tolerance"]);
                            var goal = $"{doseGoalType} {sign} {doseCriteria} {unit} ({tolerance} {unit})";

                            jw.WriteStartObject();
                            jw.WritePropertyName("doseGoal");
                            jw.WriteValue(goal);
                            jw.WriteEndObject();
                         }
                    }
                    jw.WriteEndArray();
                }
            }
        }

        public void Finish()
        {
            jw.WriteEndObject();
            jw.WriteEndObject();
            jw.WriteEndArray();
            jw.WriteEndObject();
            jw.Close();
        }
    }


}

