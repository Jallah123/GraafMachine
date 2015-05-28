using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    class NorNode: BaseNode
    {
        public override void work()
        {
            Console.WriteLine("Yeay i am a nor-node");
        }

        public override object Clone()
        {
            return new NorNode();
        }

        public override string getKey()
        {
            return "nor";
        }
    }
}
