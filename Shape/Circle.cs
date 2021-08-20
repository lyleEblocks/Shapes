using System;

namespace Shape
{
    public class Circle
    {
        private int radius;

        public Circle(int r)
        {
            
            if (r <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(radius)} cannot be 0 or negative");
            }

            radius = r;
        }

        public override bool Equals(object obj)
        {
            Circle A = obj as Circle;
            if(A.radius == this.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculateCircumference()
        {
            return Math.PI * radius * 2;
        }

        public int CalculateDiameter()
        {
            return radius * 2;
        }
    
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}