using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    public class EventLoop
    {
        public event EventHandler OnArrowUp = (sender, args) => { };
        public event EventHandler OnArrowDown = (sender, args) => { };
        public event EventHandler OnArrowLeft = (sender, args) => { };
        public event EventHandler OnArrowRight = (sender, args) => { };

        public void Run()
        {
            for (ConsoleKey key = ConsoleKey.NoName; key != ConsoleKey.Escape;)
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                    {
                        OnArrowUp(this, EventArgs.Empty);
                        break;
                    }

                    case ConsoleKey.DownArrow:
                    {
                        OnArrowDown(this, EventArgs.Empty);
                        break;
                    }

                    case ConsoleKey.LeftArrow:
                    {
                        OnArrowLeft(this, EventArgs.Empty);
                        break;
                    }

                    case ConsoleKey.RightArrow:
                    {
                        OnArrowRight(this, EventArgs.Empty);
                        break;
                    }
                }
            }
        }
    }
}
