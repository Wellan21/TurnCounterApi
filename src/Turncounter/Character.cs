using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turncounter.Entities
{
    class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Spell> Spells { get; set; }
    }

}
