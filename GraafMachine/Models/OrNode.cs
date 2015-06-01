using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    class OrNode: BaseNode
    {
        public OrNode()
        {
            inputs = new bool[2];
        }

        public override void work()
        {
            Console.WriteLine("I am a ||-node");
        }
        public override object Clone()
        {
            return new OrNode();
        }

        public override string getKey()
        {
            return "OR";
        }
    }
}
