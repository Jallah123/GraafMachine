using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    class XorNode: BaseNode
    {
        public override void work()
        {
            Console.WriteLine("Yeay i am a xor-node");
        }

        public override object Clone()
        {
            return new XorNode();
        }

        public override string getKey()
        {
            return "XOR";
        }
    }
}
