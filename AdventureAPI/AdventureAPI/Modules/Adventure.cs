using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureAPI.Modules
{
    public class Adventure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
