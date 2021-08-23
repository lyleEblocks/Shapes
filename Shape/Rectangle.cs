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
    /// <summary>
    ///     A <see cref ="Rectangle"/> class that calculates rectangle formulas.
    /// </summary>
    public class Rectangle
    {
        private int length;
        private int width;
        /// <summary>
        ///     Initailizes the instance of the <see cref ="Rectangle"/> class.
        /// </summary>
        /// <param name="length">
        ///     Measurement of the rectangle length.
        /// </param>
        /// <param name="width">
        ///    Measurement of the rectangle width.
        /// </param>
        public Rectangle(int length, int width)
        {
            if (length <= 0 || width <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(width)} or {nameof(length)} cannot be 0 or negative");
            }

            this.length = length;
            this.width = width;
        }
        /// <summary>
        ///      The <see cref="Equals"/> method compares the equality of the rectangles. 
        /// </summary>
        /// <param name="obj">
        ///      Object name
        /// </param>
        /// <returns>
        ///     True if the rectangles are equal and false if they are not.
        /// </returns>
        public override bool Equals(object obj)
        {
            Rectangle B =  obj as Rectangle;
            
            if(B != null && this.length == B.length && this.width == B.width)
                return true;
            else
                return false;
        }
        /// <summary>
        ///      <see cref="CalculateArea"/> calculates the area of a rectangle.
        /// </summary>
        /// <returns>
        ///      Area of a rectangle depending on the value that was inputted.
        /// </returns>
        public double CalculateArea()
        {
            if(width <= 0 || length <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(width)} or {nameof(length)} cannot be 0 or negative");
            }
            return length * width;
        }
    /// <summary>
    ///      The method<see cref="GetHashCode"/>provides this hash code for algorithms that need quick checks of object equality.
    /// </summary>
    /// <returns>
    ///     An integer value which can be used as a hash code.
    /// 
    /// </returns>
       public override int GetHashCode()
       {
            return base.GetHashCode();
       }
    }
    /// <summary>
    ///      A <see cref="Circle"/> class that calculates circle formulas.
    /// </summary>
    public class Circle
    {
        //private double PI ;
        private double radius;
        
        /// <summary>
        ///     Initializes instances of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="PI">
        ///     Cirlce PI which is 3.141.
        /// </param>
        /// <param name="radius">
        ///     Circle radius which is any positive value.
        /// </param>
        public Circle( double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(radius)} cannot be zero or negative");
            }
            //this.PI = Math.PI;
            this.radius = radius;
        }
        /// <summary>
        ///      <see cref="CalculateCircum"/> calculates the circumference of a circle.
        /// </summary>
        /// <param name="PI">
        ///      Cirlce PI which is 3.141.
        /// </param>
        /// <param name="radius">
        ///      Circle radius which is any positive value.
        /// </param>
        /// <returns> 
        ///      The result of the circle's circumference.
        /// </returns>
        public double CalculateCircum(){
            double result = 2*Math.PI*radius;
            return result;
        }
        /// <summary>
        ///      <see cref="Calculate_Area_Of_Circle"/> calculates the area of a circle.
        /// </summary>
        /// <param name="PI">
        ///      Cirlce PI which is 3.141.
        /// </param>
        /// <param name="radius">
        ///      Circle radius which is any positive value.
        /// </param>
        /// <returns>
        ///      The result of the circle Area.
        /// </returns>
        public double Calculate_Area_Of_Circle( )
        {
            double result = Math.PI * Math.Pow(radius, 2);
            return result;
        }
        /// <summary>
        ///      <see cref="Calculate_Diameter_Of_Circle"/> calculates the diameter of a circle.
        /// </summary>
        /// <param name="two">
        ///      The number two in the diameter formula of the circle.
        /// </param>
        /// <param name="radius">
        ///      Circle radius which is any positive value.
        /// </param>
        /// <returns>
        ///      The result of the circle diameter.
        /// </returns>
        public double Calculate_Diameter_Of_Circle( )
        {
            double result = 2*radius;
            return result;
        }
    }
    /// <summary>
    ///      A <see cref="Square"/> class that calculates square formulas.
    /// </summary>
    public class Square{
        private double area;
         private double perimeter;
         private double diagonal;
        /// <summary>
        ///      Initializes instances of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="area">
        ///     The area of a square.
        /// </param>
        public Square(double area)
        {
            this.area = area;
        }
        /// <summary>
        ///     <see cref="Calculate_Area_of_A_Square"/> method calculates the area of a square.
        /// </summary>
        /// <param name="area">
        ///     The area of a square.
        /// </param>
        /// <returns>
        ///    The result of the square area.
        /// </returns>
        public double Calculate_Area_of_A_Square(double area)
        {
            double result = Math.Pow(area, 2);
            return result;
        }
        /// <summary>
        ///     <see cref="Calculate_Perimeter_of_A_Square"/> method calculates the perimeter of a square.
        /// </summary>
        /// <param name="perimeter">
        ///     The perimeter of a square.
        /// </param>
        /// <returns>
        ///    The result of the square perimeter.
        /// </returns>
        public double Calculate_Perimeter_of_A_Square(double perimeter)
        {
            double result = 4*(perimeter);
            return result;
        }
        /// <summary>
        ///     <see cref="Calculate_Diagonal_of_A_Square"/> method calculates the diagonal of a square.
        /// </summary>
        /// <param name="diagonal">
        ///     The diagonal of a square.
        /// </param>
        /// <returns>
        ///    The result of the square diagonal.
        /// </returns>
        public double Calculate_Diagonal_of_A_Square(double diagonal)
        {
            double result = Math.Pow(diagonal, 2)+ Math.Pow(diagonal, 2);
            return result;
        }

    }
}