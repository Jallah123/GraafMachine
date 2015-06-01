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
            inputs = new bool[1];
        }

        public override void work()
        {
            Console.WriteLine(name + ":" + inputs[0]);
        }

        public override object Clone()
        {
            return new ProbeNode();
        }

        public override string getKey()
        {
            return "probe";
        }
    }
}
