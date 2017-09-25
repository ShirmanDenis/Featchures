using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParseReplaceOperators
{
    class OpParser : IDisposable
    {
        public IDataProvider DataProvider { get; set; }
        public readonly StringBuilder Result = new StringBuilder();

        private readonly StreamReader inputContext;
        private readonly Regex regex = new Regex("(?<varibles>{{[ ]?(?<varName>[a-zA-Z0-9]+)[ ]?}})", RegexOptions.Singleline);

        public OpParser(IDataProvider dataProvider, string filePath)
        {
            DataProvider = dataProvider;
            if (!File.Exists(filePath)) File.WriteAllText(filePath, "");
            inputContext = File.OpenText(filePath);
        }

        public void Parse()
        {
            while (!inputContext.EndOfStream)
            {
                var currentString = inputContext.ReadLine();
                FindAndReplaceOperators(currentString);               
            }
        }

        public void Dispose()
        {
            inputContext?.Dispose();
        }

        private void FindAndReplaceOperators(string inputString)
        {
            if(!regex.IsMatch(inputString)) return;
            var changedStr = regex.Replace(inputString, MatchEvaluator);
            Result.AppendLine(changedStr);
        }

        private string MatchEvaluator(Match currentMatch)
        {
            if (currentMatch.Groups["varibles"].Success)
            {
                var varGroup = currentMatch.Groups["varName"];
                var varName = varGroup.Value;
                var varValue = DataProvider.GetString(varName);
                return varValue;
            }
            return "NAN";
        }
    }
}
