using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

// Coded by Natasha Martinez
namespace MapEditor
{
    class Reader
    {
        public List<String> loc;
        // Read it 
        StreamReader input;
        public List<String> Read(string file)
        {
            input = new StreamReader(file);

            // Store the strings into a list
            loc = new List<string>();
            string temp;
            while ((temp = input.ReadLine()) != null)
            {
                loc.Add(temp);
            }
            if (input != null)
            {
                input.Close();
            }
            return loc;
        }
    }
}
