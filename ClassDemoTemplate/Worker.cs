using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoTemplate
{
    public class Worker
    {
        public void Start()
        {
            List<String> data = new List<string>()
            {
                "Peter",
                "Anders",
                "Vibeke",
                "Michael C"
            };

            AbstractTemplateClass temp = new therTSubTemplate();
            temp.InsertTemplateMethod(data);

            Console.WriteLine(temp);

        }
    }
}
