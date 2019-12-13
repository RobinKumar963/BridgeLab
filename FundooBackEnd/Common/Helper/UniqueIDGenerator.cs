using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Helper
{
    public class UniqueIDGenerator
    {
        public static string GenerateUniqueString()
        {
            ////For creating unique ID string
            long unique = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                unique *= ((int)b + 1);
            }
            string id = string.Format("FUNDOO{0:x}", unique - DateTime.Now.Ticks);

            return id;
        }
    }
}
