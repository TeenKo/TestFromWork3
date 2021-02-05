using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class NPC : GameObject
    {
        public NPC(int x, int y, char renderSymbol) : base(x, y, renderSymbol)
        {

        }

        public override void Action()
        {
            base.Action();
            Console.WriteLine("I`m simmple NPC");
        }
    }
}
