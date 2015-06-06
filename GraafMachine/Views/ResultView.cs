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
            
        }
        public void print(String input)
        {
            Console.WriteLine(input);
        }
        public void printNodeInfo(BaseNode node, bool output)
        {
            Console.WriteLine("{0}: {1}", node.getName(), output);
        }
        public static ResultView getInstance()
        {
            if (instance == null)
            {
                instance = new ResultView();
            }
            return instance;
        }
    }
}
