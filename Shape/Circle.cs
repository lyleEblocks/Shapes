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

namespace Shape.Tests
{
    /// <summary>
    ///     Provides multiple circle calculation functions.
    /// </summary>
    public class Circle
    {
        /// <summary>
        ///     Declares the radius of the circle.
        /// </summary>
        private double radius;

        /// <summary>
        ///     Instantiates an instance of <see cref="Circle">. 
        /// </summary>
        /// <param name="radius">
        ///     A <see cref="double"> representing the radius of a circle.
        /// </param>
        public Circle(double radius)
        {
            if (radius <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(radius)}  cannot be 0 or negative");
            }
            this.radius = radius;
        }

        /// <summary>
        ///     Validates whether two circles are equal.
        /// </summary>
        /// <param name="obj">
        ///     An <see cref="object"> representing the second circle to compare to the current <see cref="Circle">.
        /// </param>
        /// <returns>
        ///     A <see cref="bool"> representing whether the two circles are equal or not.
        /// </returns>
        public override bool Equals(object obj)
        {
            Circle B =  obj as Circle;
            
            if(B != null && this.radius == B.radius)
                return true;
            else
                return false;
        }

        /// <summary>
        ///     Calculating the area of the circle. 
        /// </summary>
        /// <returns>
        ///     A <see cref="double"> representing the area of the circle.
        /// </returns>
        public double CalculateArea()
        {
            return this.radius*(Math.Pow(Math.PI,2));
        }

        /// <summary>
        ///     Calculating the circumference of the cirle.
        /// </summary>
        /// <returns>
        ///      A <see cref="double"> representing the circumference of the circle.
        /// </returns>
        public double CalculateCircumference()
        {
            return 2*this.radius*(Math.PI);
        }
        
        /// <summary>
        ///     Calculating the diameter of the cirle.
        /// </summary>
        /// <returns>
        ///      A <see cref="double"> representing the diameter of the circle.
        /// </returns>
        public double CalculateDiameter()
        {
            return 2*this.radius;
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