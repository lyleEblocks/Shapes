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
           private double radius ;    
       
           public Circle(double PI, double radius)
           {
              if(radius <= 0)
              {
                throw new ArgumentOutOfRangeException($" {nameof(radius)} cannot be zero or negative");
              }
              this.PI = Math.PI;
              this.radius = radius;
           }
           public double CalculateCircum(double PI, double radius){
               double result = 2*Math.PI*radius;
               return result;
           }
       }


           public class Diameter{
            private double radius;

            public Diameter(double radius){
               this.radius = radius;
            }
           
           public double CalculateDiameter(double radius){
           if (radius <= 0)
           {
               throw new ArgumentOutOfRangeException($" {nameof(radius)} cannot be zero or negative");
           }
           double result = 2*radius;
           return result;
           }
           }
          
}