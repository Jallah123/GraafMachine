using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    class AndNode: BaseNode
    {
        public AndNode()
        {
            inputs = new bool[2];
        }

        public override void work()
        {
            if(inputs.Length == 2)
            {
                foreach(BaseNode node in outputNodes)
                {
                    node.addInput((inputs[0] && inputs[1]));
                }
            }
        }

        public override object Clone()
        {
            return new AndNode();
        }

        public override string getKey()
        {
            return "AND";
        }
    }
}
