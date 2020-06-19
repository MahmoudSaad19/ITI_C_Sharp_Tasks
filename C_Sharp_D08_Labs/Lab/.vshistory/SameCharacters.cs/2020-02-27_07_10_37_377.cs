using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab
{
    class SameCharacters : IEqualityComparer<string>
    {
        public bool Equals( string x,  string z)
        {
            return x.Length == z.Length && x
        }

        public int GetHashCode( string obj)
        {
            throw new NotImplementedException();
        }
    }
}
