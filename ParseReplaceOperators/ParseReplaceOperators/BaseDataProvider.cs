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

        public BaseDataProvider(string filePath)
        {
            var vars = File.ReadAllLines(filePath);

            foreach (var str in vars)
            {
                var parsedVariable = str.Split();
                VariablesValues.Add(parsedVariable[0], parsedVariable[1].Trim('\"'));
            }
        }

        public string GetString(string name)
        {
            return VariablesValues[name];
        }

        public int GetSequenceCount()
        {
            throw new NotImplementedException();
        }

        public void SetElement(string value, int i)
        {
            throw new NotImplementedException();
        }
    }
}
