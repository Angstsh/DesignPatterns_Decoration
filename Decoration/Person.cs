using System;
using System.Collections.Generic;
using System.Text;

namespace Decoration
{
    class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("装扮的{0}",name);
        }
    }
}
