using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseReplaceOperators
{
    interface IDataProvider
    {
        string GetString(string name);
        int GetSequenceCount();
        void SetElement(string value, int i);
    }
}
