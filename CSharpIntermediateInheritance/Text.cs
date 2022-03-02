using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateInheritance
{   

    public class Text : PresentationObject //So this is the inheritance notation we just put a colon here and the name of the base class.
                                           //Note that in C-sharp a class can have only one parent.
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}
