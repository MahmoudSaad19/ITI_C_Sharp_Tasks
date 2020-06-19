using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab
{
    class SameCharacters : IEqualityComparer<string>
    {
        //{ "from   ", " salt", " earn ", "  last   ", " near ", " form  " }
        public bool Equals( string l,  string z)
        {
            Char[] left = l.Trim().ToCharArray();
            Array.Sort(left);
            Char[] right = z.Trim().ToCharArray();
            Array.Sort(right);
            return l.Trim().Length == z.Trim().Length && left.Equals(right);
        }

        public int GetHashCode( string obj)
        {
            return base.GetHashCode();
        }

    }
}
