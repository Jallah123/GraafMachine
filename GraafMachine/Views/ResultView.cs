using GraafMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Views
{
    public class ResultView
    {
        private static ResultView instance;

        private ResultView()
        {
            printArt();
            Console.WriteLine("Name\tType\tIN\t\tOUT");
            Console.WriteLine("--------------------------------------");
        }
        public void print(String input)
        {
            Console.WriteLine(input);
        }
        public void printNodeInfo(BaseNode node, bool output)
        {
            Console.Write("{0}\t{1}\t", node.getName(), node.getKey());
            foreach (bool b in node.getInputs()){ 
                Console.Write("{0}\t", b);
            }
            if (node.getInputs().Count ==1) {
                Console.Write("\t{0}\n", output);
            }else {
                Console.Write("{0}\n", output);
            }
        }
        public static ResultView getInstance()
        {
            if (instance == null)
            {
                instance = new ResultView();
            }
            return instance;
        }

        private void printArt()
        {
            Console.WriteLine(" __ _  _  _  __    _  __   ___    __");
            Console.WriteLine("/__|_)|_||_||_ |V||_|/  |_| | |\\||_ ");
            Console.WriteLine("\\_|| \\| || ||  | || |\\__| |_|_| ||__");
            Console.WriteLine();
        }
    }
}
