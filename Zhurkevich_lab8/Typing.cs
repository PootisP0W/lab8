using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhurkevich_lab8
{
    internal class Typing
    {
        private string text { get; set; }
        public int Count { get; private set; }
        public bool Alive { get;  set; }

        public Typing(string text, int count, bool alive)
        {
            this.text = text;
            Count = count;
            Alive = alive;
        }

        public void TyipngText()
        {
            Console.Clear();
            Console.WriteLine("Тест на скоропечатание\n-----------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text.Substring(0, Count));
            Console.ResetColor();
            Console.Write(text.Substring(Count));
            if (Console.ReadKey(true).KeyChar == text[Count])
            {
                Count++;
            }
            if (Count == text.Length)
            {
                Alive = false;
            }
        }
    }
}
