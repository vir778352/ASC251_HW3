using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class PersonEventArgs : EventArgs
    {
        public string Name { get; set; }
        public double HealthPoint { get; set; }
        public int Level { get; set; }
    }
}
