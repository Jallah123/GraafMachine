using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    class InputLowNode : BaseNode
    {
        public override object Clone()
        {
            return new InputLowNode();
        }

        public override string getKey()
        {
            return "INPUT_LOW";
        }

        public override void work()
        {
            foreach (BaseNode node in outputNodes)
            {
                node.addInput(false);
            }
        }
    }
}
