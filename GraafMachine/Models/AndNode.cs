using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Models
{
    class AndNode: BaseNode
    {
        public override void work()
        {
            Console.WriteLine("Yeay i am a &-node");
        }

        public override object Clone()
        {
            return new AndNode();
        }

        public override string getKey()
        {
            return "and";
        }
    }
}
