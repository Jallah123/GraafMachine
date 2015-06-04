using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    class ProbeNode: BaseNode
    {
        public ProbeNode()
        {
            inputs = new List<bool>(1);
        }

        public override void work()
        {
            if (inputs.Count() == 1) { 
                Console.WriteLine(name + ":" + inputs[0]);
            }
        }

        public override object Clone()
        {
            return new ProbeNode();
        }

        public override string getKey()
        {
            return "PROBE";
        }
    }
}
