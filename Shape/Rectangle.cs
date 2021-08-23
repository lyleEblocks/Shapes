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
    ///     Provides rectangle calculations.
    /// </summary>
    public class Rectangle
    { 
        /// <summary>
        ///     Declares the length of the rectangle.
        /// </summary>
        private double length;

        /// <summary>
        ///      Declares the width of the rectangle.
        /// </summary>
        private double width;

        /// <summary>
        ///     Instantiates a rectangle object.
        /// </summary>
        /// <param name="length">
        ///     A <see cref="double"> representing the length of the rectangle.
        /// </param>
        /// <param name="width">
        ///     A <see cref="double"> representing the width of the rectangle.
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
        ///     Gets a <see cref="double"> representing the length of the rectangle.
        /// </summary>
        public double Length
        {
            get { return length; }
        }

        /// <summary>
        ///     Validates whether two rectangles are equal.
        /// </summary>
        /// <param name="obj">
        ///     A <see cref="object"> representing the second rectangle to equate to the first.
        /// </param>
        /// <returns>
        ///     A <see cref="bool"> representing whether the rectangles are equal or not. 
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
        ///     Calculates the area of the rectangle.
        /// </summary>
        /// <returns>
        ///     A <see cref="double"> representing the area of the rectangle. 
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
        ///     Overrides the <see cref = "GetHashCode"> method.
        /// </summary>
        /// <returns>
        ///     A GetHashCode value.
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}