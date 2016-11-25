using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013LINq
{
    class MartialArtsMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Menpai { get; set; }
        public string Kongfu { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Age)}: {Age}, {nameof(Menpai)}: {Menpai}, {nameof(Kongfu)}: {Kongfu}, {nameof(Level)}: {Level}";
        }
    }
}
