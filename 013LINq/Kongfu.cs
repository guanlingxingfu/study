using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013LINq
{
    class Kongfu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Power)}: {Power}";
        }
    }
}
