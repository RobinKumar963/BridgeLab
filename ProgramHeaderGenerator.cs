using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bridgelabz.ProgramHeaderGenerator
{
    public class ProgramHeaderGenerator : HeaderGenerator
    {
        String username;
        String company;
        

        public ProgramHeaderGenerator(string username, string company)
        {
            this.username = username;
            this.company = company;
            
        }

        public ProgramHeaderGenerator()
        {

        }

        public void GenerateHeader(String filename)
        {
            StreamWriter sw = new StreamWriter(filename,false);
            sw.Write("this is header");

        }


    }
}
