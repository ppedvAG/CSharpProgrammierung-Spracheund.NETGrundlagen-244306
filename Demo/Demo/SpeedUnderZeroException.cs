using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class SpeedUnderZeroException : Exception
    {
        public SpeedUnderZeroException() : base("Geschwindigkeit darf nicht unter 0 sein")
        {
        }
    }
}
