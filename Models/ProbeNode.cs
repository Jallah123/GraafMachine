using System;
using System.Collections.Generic;
using System.Linq;
using GraafMachine.Controllers;

namespace GraafMachine.Models
{
    public class ProbeNode: BaseNode
    {
        
        public ProbeNode()
        {
            inputs = new List<bool>(1);
        }

        public override void work()
        {
            if (inputs.Count() == 1) {
                notifyObservers(inputs[0]);
            }
        }

        public override object Clone()
        {
            return new ProbeNode();
        }

        public override string getKey()
        {
            return "PROBE";
        }
    }
}
