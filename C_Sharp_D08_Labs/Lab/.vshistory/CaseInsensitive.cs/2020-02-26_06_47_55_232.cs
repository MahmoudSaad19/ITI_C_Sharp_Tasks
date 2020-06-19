using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab
{
    class CaseInsensitive : IComparer<string>
    {
        public int Compare( string x,  string y)
        {
            return x.CompareTo(y);
        }
    }
}
