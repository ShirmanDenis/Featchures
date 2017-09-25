using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseReplaceOperators
{
    class BaseDataProvider : IDataProvider
    {
        private readonly Dictionary<string, string> VariablesValues = new Dictionary<string, string>();
        private readonly Dictionary<string, string[]> Sequences = new Dictionary<string, string[]>();
        public BaseDataProvider(string filePath)
        {
            var vars = File.ReadAllLines(filePath);

            foreach (var str in vars)
            {
                var parsedVariable = str.Split(',');
                VariablesValues.Add(parsedVariable[0], parsedVariable[1].Trim('\"', ' '));
            }
        }

        public string GetString(string name)
        {
            return VariablesValues[name];
        }

        public int GetSequenceCount(string name)
        {
            var items = VariablesValues[name].Trim('\"').Split();
            Sequences.Add(name, items);
            return items.Length;
        }

        public void SetElement(string sequenceName, string value, int i)
        {
            Sequences[sequenceName][i] = value;
        }
    }
}
