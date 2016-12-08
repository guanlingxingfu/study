using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030项目
{
    class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Lang { get; set; }
        public int Damage { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Lang)}: {Lang}, {nameof(Damage)}: {Damage}";
        }
    }
    }

