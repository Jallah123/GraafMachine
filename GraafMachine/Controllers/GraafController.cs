using GraafMachine.Models;
using GraafMachine.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Controllers
{
    public class GraafController
    {
        private List<BaseNode> nodes;
        public GraafController()
        {
            nodes = new List<BaseNode>();
            // Make parser
            // Create folder in the bin directory called "circuits" and add circuits there
            GraafParser parser = new GraafParser(@"circuits/circuit3.txt");
            generateNodes(parser.getLines());
            work();
        }

        private void generateNodes(List<String> lines)
        {
            // Loop through all lines
            foreach(String line in lines) {

                string[] lineSplit = line.Split(':');
                string nodeName = lineSplit[0];
                string nodeType = lineSplit[1];

                bool exists = checkExistence(nodeName);

                if (exists)
                {
                    // Create link
                    string[] outputNodes = nodeType.Split(',');
                    linkNodes(nodeName, outputNodes);
                } else
                {
                    try
                    {
                        nodes.Add(createNode(nodeName, nodeType));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error generating node type: {0}. With name : {1}.", nodeType, nodeName);
                    }
                }
            }
        }
        private void work()
        {
            foreach (BaseNode node in nodes)
            {
                if (node.getKey().Equals("INPUT_HIGH") || node.getKey().Equals("INPUT_LOW"))
                {
                    node.work();
                }
            }
        }
        private BaseNode createNode(string name, string type)
        {
            BaseNode node = BaseNode.create(type);
            // Set name and add to list
            node.setName(name);
            node.Subscribe(this);
            return node;
        }

        private void linkNodes(string name, string[] nodes)
        {
            BaseNode inputNode = getNode(name);
            for (var i = 0; i < nodes.Length; i++)
            {
                BaseNode outputNode = getNode(nodes[i]);
                inputNode.addOutputNode(outputNode);
            }
        }

        private bool checkExistence(string name)
        {
            return getNode(name) != null;
        }

        private BaseNode getNode(string name)
        {
            foreach (BaseNode node in nodes)
            {
                if (node.getName().Equals(name))
                {
                    return node;
                }
            }
            return null;
        }

        public void printOutput(BaseNode value, bool output)
        {
            ResultView.getInstance().printNodeInfo(value, output);
        }
    }
}
