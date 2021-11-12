using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS10newDeconstruction
{
    internal class Author
    {
        public Author(string name, string lastName)
        {
            Name = name;
            LastName = lastName;

        }
        public Author(string name, string lastName, string description)
        {
            Name = name;
            LastName = lastName;
            Description = description;

        }

        public string Name { get; set; }
        public string LastName { get; set; }

        public string? Description { get; set; }
        internal void Deconstruct(out string name, out string lastName)
        {
            name = Name;
            lastName =LastName;
        }

    }
}
