using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            EventLoop eventLoop = new EventLoop();
            eventLoop.OnArrowUp += CursorMover.MoveUp;
            eventLoop.OnArrowDown += CursorMover.MoveDown;
            eventLoop.OnArrowLeft += CursorMover.MoveLeft;
            eventLoop.OnArrowRight += CursorMover.MoveRight;

            eventLoop.Run();
        }
    }
}
