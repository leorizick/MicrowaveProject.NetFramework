using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttoMicrowave.services.exceptions
{
    public class TimeInvalidException : EventArgs
    {
        public string Error { get; set; }

        public TimeInvalidException(string error)
        {
            Error = error;
        }
    }
}
