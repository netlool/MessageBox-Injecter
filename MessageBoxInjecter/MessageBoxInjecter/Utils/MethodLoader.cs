using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxInjecter.Utils
{
    class MethodLoader
    {
        public static List<String> LoadMethods()
        {
            List<String> methods = new List<String>();
            foreach(var type in Globals.md.Types)  {
                foreach (var method in type.Methods)
                {
                    methods.Add(type.Name + ":" + method.Name);
                }

               }

            return methods;
        }

    }
}
