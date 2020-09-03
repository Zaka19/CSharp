using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureAPI.Modules
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Skill { get; set; }
        public int AdventureId { get; set; }
        public Adventure Adventure { get; set; }
    }
}
