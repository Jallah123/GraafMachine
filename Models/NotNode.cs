using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    class NotNode : BaseNode
    {
        public NotNode()
        {
            inputs = new List<bool>(1);
        }

        public override void work()
        {
            if (inputs.Count() == 1)
            {
                output = !inputs[0];
                notifyObservers(output);
                foreach (BaseNode node in outputNodes)
                {
                    node.addInput(output);
                }
            }
        }

        public override object Clone()
        {
            return new NotNode();
        }

        public override string getKey()
        {
            return "NOT";
        }
    }
}
