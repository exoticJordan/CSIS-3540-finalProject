using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServerProject
{
    class Cruise
    {
        string Name { get; set; }
        List<string> Itinary;
        string Ship { get; set; }
        int Duration { get; set; }
        double Price { get; set; }
    }
}
