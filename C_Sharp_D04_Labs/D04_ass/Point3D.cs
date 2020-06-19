using System;
using System.Collections.Generic;
using System.Text;

namespace D04_ass
{
    class Point3D : IComparable , ICloneable 
    {
        /// Design 3D Point Class and Include the basic Constructor(s) 
        /// [use chaining in constructors] 
        /// 
        int x, y, z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D() : this(0, 0, 0) { }

        ///2. Override the ToString Function to produce this output 
        ///Point3D P = new Point3D(10, 10, 10);
        ///Console.WriteLine(Point3D.ToString());
        ///Point Coordinates:   (10, 10, 10)
        ///Try to Cast Point3D to string type

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }


        public static explicit operator string(Point3D p)
        {
            return p.ToString();
        }

        ///3.Read from the User the Coordinates for 2 point P1, P2
        ///(Check the input, tryPares, Parse, Convert )
        ///
        ///4. Try to use == 
        ///If(P1 ==P2)
        ///Does it work properly? 
        ///Try to override the Equals Function(from base Object)
        ///

        public override bool Equals(object obj)
        {
            return obj is Point3D right &&
                   x == right.x &&
                   y == right.y &&
                   z == right.z;
        }

        ///5. Define array of points: 
        ///Sort this array based on X & Y coordinates
        ///

        public int CompareTo(object obj)
        {
            Point3D p = (Point3D)obj;
            if (x == p.x)
                return y.CompareTo(p.y);
            return x.CompareTo(p.x);
        }

        ///6. Implement IClonable interface to be able to clone the object.
        ///To implement more than one interface:
        ///class Point3D : IComparable, ICloneable
        ///
        public object Clone()
        {
            return new Point3D(x,y,z);
        }
        
    }
}
