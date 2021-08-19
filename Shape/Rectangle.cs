using System;

namespace Shape
{
    public class Rectangle
    { 
        private int length;
        private int width;
        private int area;

        public Rectangle(int length, int width)
        {
            if (length <= 0 || width <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(width)} or {nameof(length)} cannot be 0 or negative");
            }

            this.length = length;
            this.width = width;
        }

        public override bool Equals(object obj)
        {
            Rectangle B =  obj as Rectangle;
            
            if(B != null && this.length == B.length && this.width == B.width)
                return true;
            else
                return false;
        }

        public double CalculateArea()
        {
            if(width <= 0 || length <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(width)} or {nameof(length)} cannot be 0 or negative");
            }
            return length * width;
        }

       public override int GetHashCode()
       {
            return base.GetHashCode();
       }
    }
}