using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_Carmichael_Nathan
{
    class Car
    {
        //Creates a field called model
        public string model;
        //Creates a property called Model
        public string Model 
        { 
            get { return model; }
            set { model = value; }
        }
        //Creates a property called Make 
        public string Make
        { get; set; }

    }
}
