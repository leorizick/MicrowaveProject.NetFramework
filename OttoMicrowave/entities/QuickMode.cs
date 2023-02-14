using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttoMicrowave.entities
{
    public class QuickMode
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public int Time { get; set; }
        public int Power { get; set; }
        public string Instruction { get; set; }
        public bool Initial { get; set; }
        public string code { get; set; }

        public override string ToString()
        {
            string data = Name + ": " + Food  + ", " + Instruction;
            return data;
        }
    }


}
