using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafMachine.Controllers
{
    class GraafParser
    {
        private List<String> lines;

        public GraafParser(String fileLocation)
        {
            lines = new List<String>();

            try
            {
                String line;
                // Read file
                StreamReader file = new StreamReader(fileLocation);
                // Loop through all lines
                while((line = file.ReadLine()) != null)
                {
                    // Check if line is a comment or empty
                    if (!line.Contains("#") || line == "")
                    {
                        // Add line to list
                        
                        lines.Add(line.Replace("\t", "").Replace(" ", ""));
                    }
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public List<String> getLines()
        {
            return lines;
        }
    }
}
