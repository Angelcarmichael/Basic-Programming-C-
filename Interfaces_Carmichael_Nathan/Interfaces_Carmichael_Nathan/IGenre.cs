using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Carmichael_Nathan
{
    interface IGenre
    {
        //An automatic property named ESRB
        string ESRB { get; }

        //An automatic property named Genre
        string Genre { get;  }

        //An automatic property named Title
        string Title { get;  }

        //Declares an method 
        public string Describe();
    }
}
