using System;

namespace Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            Console.WriteLine("\n第一种装扮：");
            Finery dtx = new TShirts();
            Finery kk = new BigTrouser();
            Finery pqx = new Sneakers();

            dtx.Show();
            kk.Show();
            pqx.Show();
            xc.Show();

            Console.WriteLine("\n第二种装扮：");
            Finery xz = new Suit();
            Finery ld = new Tie();
            Finery px = new LeatherShoes();

            xz.Show();
            ld.Show();
            px.Show();
            xc.Show();

            Console.Read();
        }
    }
}
