using System;
using System.Collections.Generic;

namespace consoleApp_TrainingOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameObject> MapObject = new List<GameObject>();
            MapObject.Add(new GameObject(15, 15, '@'));
            MapObject.Add(new GameObject(23, 23, '#'));
            MapObject.Add(new GameObject(7, 9, '%'));
            Player mainPlayer = new Player(25, 25, '1', "First Player");
            MapObject.Add(mainPlayer);
            MapObject.Add(new NPC(24, 24, '*'));
            GameObject g = new Player(1, 1, '1', "t");
            g.ToString();



            while (true)
            {
                Console.Clear();
                foreach (GameObject o in MapObject)
                {
                    o.Render();
                }
                foreach(GameObject o in MapObject )
                {
                    if(o.position.x == mainPlayer.position.x && o.position.y == mainPlayer.position.y)
                    {
                        o.Action();
                    }
                }
                mainPlayer.Controll();
            }
            Console.ReadLine();
        }
    }
    class GameObject // ООП. Абстракция - создание класса. 
    {
        public Vector2 position;
        protected char renderSymbol;
        protected int id;

        private static int count;

    
        public GameObject(int x, int y, char renderSymbol)
        {
            position = new Vector2(x, y);
            this.renderSymbol = renderSymbol;

            count++;
            id = count;
        }
        
        public void WritePosition()
        {
            Console.WriteLine("{0} : {1}", position.x, position.y);
        }

        public virtual void Render() // ООП инкапсуляция. Мы не хотим знать как происходит Render. Мы просто хотим его использовать.
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.Write(renderSymbol);
            Console.Write("{0}:{1}", position.x, position.y);
        }

        public virtual void Action()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Hello, i`m simple object");
        }

        public int GetID()
        {
            return id;
        }

        public static int GetCount()
        {
            return count;
        }

        public override string ToString()
        {
            return string.Format(" {0}: {1}[{2}]", position.x, position.y, renderSymbol);
        }
    }
}
