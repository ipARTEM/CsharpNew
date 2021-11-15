using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS10newParameterlessStructConstructors
{
    public struct Book
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string Name { get; set; }
    }
}
