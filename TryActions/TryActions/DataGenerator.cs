using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryActions
{
    public static class DataGenerator
    {
        public static string GetGuid()
        { 
            return  Guid.NewGuid().ToString();  
        }
    }
}
