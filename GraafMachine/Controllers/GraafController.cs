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
            // Create folder in the bin directory called "circuits" and add circuits there
            GraafParser parser = new GraafParser(@"circuits/circuit1.txt");
            generateNodes(parser.getLines());

        }

        private void generateNodes(List<String> lines)
        {
            // Loop through all lines
            foreach(String line in lines) {
                // lineSplit[0] is the name of the node
                // lineSplit[1] is the node type
                string[] lineSplit = line.Split(':');
                string nodeName = lineSplit[0];
                string nodeType = lineSplit[1];
                bool exists = checkExistence(nodeName);
                if (exists)
                {
                    // Create link
                } else
                {
                    createNode(nodeName, nodeType);
                }
            }

            foreach(BaseNode node in nodes)
            {
                node.work();
            }
        }

        private bool checkExistence(string name)
        {
            foreach (BaseNode node in nodes)
            {
                if (node.getName().Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void createNode(string name, string type)
        {
            try
            {
                BaseNode node = BaseNode.create(type);
                // Set name and add to list
                node.setName(name);
                nodes.Add(node);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error generating node type: {0}. With name : {1}.", type, name);
            }
        }

    }
}
