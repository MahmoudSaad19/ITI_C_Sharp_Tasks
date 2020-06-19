using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab
{
    class SameCharacters : IEqualityComparer<string>
    {
        //{ "from   ", " salt", " earn ", "  last   ", " near ", " form  " }
        public bool Equals( string l,  string r)
        {
            Char[] left = l.Trim().ToCharArray();
            Array.Sort(left);            
            Char[] right = r.Trim().ToCharArray();
            Array.Sort(right);
            return l.Trim().Length == r.Trim().Length && left.All(s=>right.Contains(s));
        }

        public int GetHashCode( string obj)
        {
            return base.GetHashCode();
        }

    }
}
