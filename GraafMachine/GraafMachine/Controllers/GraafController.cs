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
        public GraafController()
        {
            // Make parser
            GraafParser parser = new GraafParser("c:\\tmp\\graaf.txt");
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
                    Console.WriteLine("error generating");
                }
            }
        }

    }
}
