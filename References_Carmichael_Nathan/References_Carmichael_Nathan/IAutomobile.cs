using System;
using System.Collections.Generic;
using System.Text;

namespace References_Carmichael_Nathan
{
    interface IAutomobile
    {
        // An automatic property named Speed
        double Speed { get; }

        // An automatic property named Wheels
        int Wheels { get;  }

        // An automatic property named LicensePlate 
        string LicensePlate { get;  }

        // Declares a method
        public void Stringify();
    }
}
