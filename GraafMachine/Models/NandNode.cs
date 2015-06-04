using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    class NandNode: BaseNode
    {
        public NandNode()
        {
            inputs = new List<bool>(2);
        }

        public override void work()
        {
            if (inputs.Count() == 2)
            {
                foreach (BaseNode node in outputNodes)
                {
                    node.addInput((!inputs[0] || !inputs[1]));
                }
            }
        }

        public override object Clone()
        {
            return new NandNode();
        }

        public override string getKey()
        {
            return "NAND";
        }
    }
}
