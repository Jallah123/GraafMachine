using GraafMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Controllers
{
    class GraafController
    {
        private Dictionary<String, BaseNode> nodes;
        public GraafController()
        {
            nodes = new Dictionary<string, BaseNode>();
            // Make parser
            GraafParser parser = new GraafParser(@"circuits/circuit1.txt");
            generateNodes(parser.getLines());

        }

        private void generateNodes(List<String> lines)
        {
            // Loop through all lines
            foreach(String line in lines) {
                try
                {
                    BaseNode.create("and").work();
                }
                catch (Exception e)
                {
                    Console.WriteLine("error generating" + e.GetBaseException());
                }
            }
        }

    }
}
