using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServerProject
{
    public class Cruise
    {
        public string Name { get; set; }
        public List<string> Itinary;
        public string Ship { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }
    }
}
