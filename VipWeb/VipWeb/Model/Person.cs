using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VipWeb.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<string> Shoes { get; set; }
        public bool Hungry { get; set; }
        public int Age { get; set; }
    }
}
