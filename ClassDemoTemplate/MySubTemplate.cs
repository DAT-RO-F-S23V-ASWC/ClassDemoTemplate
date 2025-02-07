using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoTemplate
{
    public class MySubTemplate : AbstractTemplateClass
    {
        protected override string MakeString(string s)
        {
            return s.ToUpper();
        }
    }
}
