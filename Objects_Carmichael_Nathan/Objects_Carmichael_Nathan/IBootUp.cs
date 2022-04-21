using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Carmichael_Nathan
{
    interface IBootUp
    {
        // An automatic property named IsOn
        public bool IsOn { get; set; }

        // Declares a method
        public void PowerOnOff();
    }
}
