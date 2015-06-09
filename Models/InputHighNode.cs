using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    class InputHighNode: BaseNode
    {
        public override object Clone()
        {
            return new InputHighNode();
        }

        public override string getKey()
        {
            return "INPUT_HIGH";
        }

        public override void work()
        {
            foreach (BaseNode node in outputNodes)
            {
                node.addInput(true);
            }
        }
    }
}
