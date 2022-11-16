using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileScopeTypeSample
{
    file class Class1
    {
    }
  
    file class Class2
    {
        public Class1? obj;
    }

    file class Class3
    {
        internal static string Answer { get { return "ADDD"; } }
    }
     class Class4
    {
        internal string GetString()
        {
            var x = new Class3();
            return Class3.Answer;
        }       
    }
}
