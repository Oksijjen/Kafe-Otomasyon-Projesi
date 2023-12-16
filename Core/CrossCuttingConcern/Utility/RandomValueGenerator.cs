using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcern.Utility
{
    public static class RandomValueGenerator
    {
        public static string GenerateFileName(string extension) 
        {
            

            return DateTime.Now.Ticks.ToString() + extension;
        }
    }
}
