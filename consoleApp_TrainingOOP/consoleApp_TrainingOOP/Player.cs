using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Player : GameObject // ООП Наследование. Когда мы хотим что класс имел такие же параметры. Так же можем добавлять свои параметры
    {
        public string name;
        public Player(int x, int y, char renderSymbol, string name) : base(x, y, renderSymbol)
        {
            this.name = name; 
        }

        public void Controll()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    position.x += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    position.x -= 1;
                    break;
                case ConsoleKey.UpArrow:
                    position.y -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    position.y += 1;
                    break;
            }
        }

        public override void Action()
        {
           
        }

        public override void Render() // ООП Полимарфизм. Мы можем вызывать у GameObject метод Render , но еоторый переопределен в классе Player
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.Write("{0}[{1}]", name, renderSymbol);
        }
    }
}
