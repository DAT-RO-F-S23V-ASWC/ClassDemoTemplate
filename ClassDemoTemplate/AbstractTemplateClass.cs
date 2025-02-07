﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoTemplate
{
    public abstract class AbstractTemplateClass
    {
        private ICollection<String> _info;

        protected AbstractTemplateClass()
        {
            _info = new List<string>();
        }


        public void InsertTemplateMethod(ICollection<String> strings)
        {
            foreach (string s in strings)
            {
                // the template method use an abstract method to be overriden in subclass
                String str = MakeString(s); // <=== 
                _info.Add(str);
            }
        }

        // the method to be overriden => Template Method
        protected abstract string MakeString(string s);


        public override string ToString()
        {
            return $"Info: [{String.Join(", ", _info)}]";
        }
    }
}
