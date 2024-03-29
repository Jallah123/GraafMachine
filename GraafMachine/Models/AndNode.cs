﻿using System;
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
            inputs = new List<bool>(2);
        }

        public override void work()
        {
            if(inputs.Count() == 2)
            {
                output = (inputs[0] && inputs[1]);
                notifyObservers(output);
                foreach (BaseNode node in outputNodes)
                {
                    node.addInput(output);
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
