using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031xml文档解析技能信息
{
    class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public int TriggerType { get; set; }
        public string ImageFile { get; set; }
        public int AvailableRace { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(EngName)}: {EngName}, {nameof(TriggerType)}: {TriggerType}, {nameof(ImageFile)}: {ImageFile}, {nameof(AvailableRace)}: {AvailableRace}";
        }
    }
}
