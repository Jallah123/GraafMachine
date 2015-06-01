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
        private List<BaseNode> nodes;
        public GraafController()
        {
            nodes = new List<BaseNode>();
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
                    string[] lineSplit = line.Split(':');
                    BaseNode node = BaseNode.create(lineSplit[1]);
                    node.setName(lineSplit[0]);
                    nodes.Add(node);
                }
                catch (Exception e)
                {
                    Console.WriteLine("error generating" + e.GetBaseException());
                }
            }

            foreach(BaseNode node in nodes)
            {
                node.work();
            }
        }

    }
}
