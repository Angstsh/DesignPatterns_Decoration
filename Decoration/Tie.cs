using System;
using System.Collections.Generic;
using System.Text;

namespace Decoration
{
    //领带
    class Tie:Finery
    {
        public override void Show()
        {
            Console.Write("领带");
        }
    }
}
