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
                foreach (BaseNode node in outputNodes)
                {
                    node.addInput(!inputs[0]);
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
