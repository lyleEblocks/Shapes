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
    ///     This class represents a Circle and its dimensions.
    /// </summary>
    public class Circle
    {
        /// <summary>
        ///     A <see cref="int"/> that represents the radius of a circle.
        /// </summary>
        private int radius;

        /// <summary>
        ///     This constructor method will initialize the parameter r into the radius.
        /// </summary>
        /// <param name="r">A parameter <see cref="int"/> that represents the radius of the new circle.</param>
        public Circle(int r)
        {
            
            if (r <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(radius)} cannot be 0 or negative");
            }

            radius = r;
        }

        /// <summary>
        ///     This method will compare if two circles are the same.
        /// </summary>
        /// <param name="obj"> A <see cref="object"> that represents the circle to compare to.</param>
        /// <returns>A <see cref="bool"/> that is true if circles are the same and false if circles are not the same.</returns>
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

        /// <summary>
        ///     This method will calculate the area of the circle and return the calculated value.
        /// </summary>
        /// <returns>Returns <see cref="double"/> that represents the calculated value of the area.</returns>
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        
        /// <summary>
        ///     This method will calculate the circumfrance of the circle and return the calculated value.
        /// </summary>
        /// <returns>Returns <see cref="double"/> that represents the calculated value of the circumference.</returns>
        public double CalculateCircumference()
        {
            return Math.PI * radius * 2;
        }
        
        /// <summary>
        ///     This method will calculate the diameter of the of the circle and return the calculated value.
        /// </summary>
        /// <returns>Returns <see cref="int"/> that represents the value of the diameter of the circle.</returns>
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