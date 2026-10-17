using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Lectures
{
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {
            
        }
    }
}
