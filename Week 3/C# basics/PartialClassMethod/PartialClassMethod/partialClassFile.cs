using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassMethod
{
    partial class Program
    {
        private partial int Sum()
        {
            return 1 + 2;
        }
    }
    
}
