using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bridgelabz.ProgramHeaderGenerator
{
    class Client
    {
        public static void Main(String[] args)
        {
            List<String> files = new List<String>();
            HeaderGenerator programheaderGenerator = new ProgramHeaderGenerator();
            String directoryPathName = "C:/Header trial/BridgeLab";
            ////I got all file in bridgelabz directory and from its subdirectory with extension .cs
            String[] filePaths = Directory.GetFiles(@directoryPathName, "*.cs",SearchOption.AllDirectories);
            foreach (String filepath in filePaths )
            {
                programheaderGenerator.GenerateHeader(filepath);
            }
            
        }
       
    }
}

        
    


    

