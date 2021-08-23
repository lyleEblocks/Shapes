using System;

namespace Shape
{
    public class Rectangle
    { 
        private int length;
        private int width;
      

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
    public class Circle
    {
        private double PI;
        private double radius;
        private double two;
       
        public Circle(double PI, double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(radius)} cannot be zero or negative");
            }
            this.PI = Math.PI;
            this.radius = radius;
        }
        public double CalculateCircum(double PI, double radius){
            double result = 2*Math.PI*radius;
            return result;
        }
        public double Calculate_Area_Of_Circle( double PI, double radius)
        {
            if(radius <= 0){
                throw new ArgumentOutOfRangeException("Radius cannot be zero or a negative number.");
            }
            double result = Math.PI * Math.Pow( radius, 2);
            return result;
        }
        public double Calculate_Diameter_Of_Circle( double two ,double radius)
        {
            if(radius <= 0){
                throw new ArgumentOutOfRangeException("Radius cannot be zero or a negative number.");
            }
            double result = radius * two;
            return result;
        }
        
    }
}