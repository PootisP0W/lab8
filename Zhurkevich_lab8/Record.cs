using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhurkevich_lab8
{
    internal class Record
    {
        public string Name { get; set; }
        public double CharactersPerMinute { get; set; }
        public double CharactersPerSecond { get; set; }

        public Record(string name, double charactersPerMinute, double charactersPerSecond)
        {
            Name = name;
            CharactersPerMinute = charactersPerMinute;
            CharactersPerSecond = charactersPerSecond;
        }
    }
}
