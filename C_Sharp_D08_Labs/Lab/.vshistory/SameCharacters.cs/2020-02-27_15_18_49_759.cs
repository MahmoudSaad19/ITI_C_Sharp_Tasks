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
            Char[] left = x.Trim().ToCharArray();
            Array.Sort(left);
            Char[] right = x.Trim().ToCharArray();
            Array.Sort(right);
            return x.Trim().Length == z.Trim().Length && left.Equals(right);
        }

        public int GetHashCode( string obj)
        {
            return base.GetHashCode();
        }

    }
}
