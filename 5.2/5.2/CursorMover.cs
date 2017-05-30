using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    public class CursorMover
    {
        public static void MoveUp(object sender, EventArgs args)
        {
            if (Console.CursorTop > 0)
            {
                Console.CursorTop--;
            }
        }

        public static void MoveDown(object sender, EventArgs args)
        {
            if (Console.CursorTop < Console.BufferHeight - 1)
            {
                Console.CursorTop++;
            }
        }

        public static void MoveLeft(object sender, EventArgs args)
        {
            if (Console.CursorLeft > 0)
            {
                Console.CursorLeft--;
            }
        }

        public static void MoveRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft < Console.BufferWidth - 1)
            {
                Console.CursorLeft++;
            }
        }
    }
}
