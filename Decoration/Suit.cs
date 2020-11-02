using System;
using System.Collections.Generic;
using System.Text;

namespace Decoration
{
    //西装
    class Suit:Finery
    {
        public override void Show()
        {
            Console.Write("西装");
        }
    }
}
