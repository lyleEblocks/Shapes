/*
 * [2019] - [2021] Eblocks Software (Pty) Ltd, All Rights Reserved.
 * NOTICE: All information contained herein is, and remains the property of Eblocks
 * Software (Pty) Ltd.
 * and its suppliers (if any). The intellectual and technical concepts contained herein
 * are proprietary
 * to Eblocks Software (Pty) Ltd. and its suppliers (if any) and may be covered by South 
 * African, U.S.
 * and Foreign patents, patents in process, and are protected by trade secret and / or 
 * copyright law.
 * Dissemination of this information or reproduction of this material is forbidden unless
 * prior written
 * permission is obtained from Eblocks Software (Pty) Ltd.
*/

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
    public class Square{
        private double area;
         private double perimeter;
         private double diagonal;

        public Square(double area)
        {
            this.area = area;
        }
        public double Calculate_Area_of_A_Square(double area)
        {
            double result = Math.Pow(area, 2);
            return result;
        }
        public double Calculate_Perimeter_of_A_Square(double perimeter)
        {
            double result = 4*(perimeter);
            return result;
        }
        public double Calculate_Diagonal_of_A_Square(double diagonal)
        {
            double result = Math.Pow(diagonal, 2)+ Math.Pow(diagonal, 2);
            return result;
        }

    }
}