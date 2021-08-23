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
    ///     This class represents a rectangle and provides methods for comparing equality and calculating area.   
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        ///     A <see cref="double" /> representing the length of the rectangle.
        /// </summary>
        private double length;
        
        /// <summary>
        ///     A <see cref="double" /> representing the width of the rectangle.
        /// </summary>
        private double width;

        /// <summary>
        ///     Initialises a new instance of the <see cref="Rectangle" /> class with it's length and width.
        /// </summary>
        /// <param name="length">
        ///     A <see cref="double" /> representing the length of the rectangle.
        /// </param>
        /// <param name="width">
        ///     A <see cref="double" /> representing the width of the rectangle.
        /// </param>
        public Rectangle(double length, double width)
        {
            if (length <= 0 || width <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(width)} or {nameof(length)} cannot be 0 or negative");
            }

            this.length = length;
            this.width = width;
        }

        /// <summary>
        ///     Override the <c>Object.Equals</c> method. Determines if the provided object is equal to the rectangle object by value comparision. 
        /// </summary>
        /// <param name="obj">
        ///     An <see cref="object" /> representing the object to compare equality by value.
        /// </param>
        /// <returns>
        ///     A <see cref="bool" /> indicating whether the rectangle and object are equal.
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
        ///     This method will calculate the Area of the rectangle or throw an OverflowException if the area returned is an infinity number. 
        /// </summary>
        /// <returns>
        ///     A <see cref="double" /> representing the area of the rectangle.  
        /// </returns>
        public double CalculateArea()
        {
            double area = length * width; 
            if (double.IsInfinity(area)) 
            {
                throw new OverflowException("Length or width is too large to calculate area.");
            }
            return length * width;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    
        /// <summary>
        ///     Calculates the perimeter of the rectangle. Throws an <see cref="OverflowException" /> if the perimeter returned is infinity.
        /// </summary>
        /// <returns>
        ///     A <see cref="double" /> representing the perimeter.
        /// </returns>
        public double CalculatePerimeter()
        {
            double perimeter = 2*length + 2* width;
            if (double.IsInfinity(perimeter))
            {
                throw new OverflowException("Length or width too large to calculate perimeter");
            }
            return perimeter;
        }
    }
}