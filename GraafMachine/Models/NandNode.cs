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
            inputs = new bool[2];
        }

        public override void work()
        {
            Console.WriteLine("Yeay i am a Nandnode");
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
