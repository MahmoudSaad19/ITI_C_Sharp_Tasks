using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab
{
    class SameCharacters : IEqualityComparer<string>
    {
        //{ "from   ", " salt", " earn ", "  last   ", " near ", " form  " }
        public bool Equals( string x,  string z)
        {
            return x.Trim().Length == z.Trim().Length;
        }

        public int GetHashCode( string obj)
        {
            return base.GetHashCode();
        }

    }
}
