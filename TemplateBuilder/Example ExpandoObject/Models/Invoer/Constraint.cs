using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_ExpandoObject.Models
{
    public class Constraint
    {
        // attributes
        public Dictionary<string, object> dict = new();

        public string Name { get; set; }
        public string ConstraintType { get; set; }

        // constructor(s)
        public Constraint() { 
        }

        public Constraint(
            string name,
            string constraintType)
        {
            this.Name = name;
            this.ConstraintType = constraintType;
        }

        public Constraint(Dictionary<string, object> dict)
        {
            this.dict = dict;
            this.Name = (string)dict["name"];
            this.ConstraintType = (string)dict["type"];
        }

        // methods
        public void Add(string key, object value)
        {
            dict.Add(key, value);
        }

        public static Constraint BuildConstraint(string headerline, string line)
        {
            string[] headers = headerline.Split(';');
            string[] values = line.Split(';');

            Dictionary<string, object> dict = new();
            for (var i = 0; i < headers.Length; i++) {
                var key = headers[i];
                var value = values[i];
                dict.Add(key, value);
            }

            string name = (string)dict["name"];
            string constraintType = (string)dict["type"];
            var constraint = new Constraint(name, constraintType);
            constraint.dict = dict;

            return constraint;
        }

    }
}
