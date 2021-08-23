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
    ///     Represents a circle and provides methods for comparing equality and calculating area, perimeter and diameter.
    /// </summary>
    public class Circle
    {
        /// <summary>
        ///     A <see cref="double" /> representing the radius of the circle.
        /// </summary>
       private double radius;

       /// <summary>
       ///     Initialises a new instance of the <see cref="Circle" /> class with its radius.
       /// </summary>
       /// <param name="radius">
       ///     A <see cref="double" /> representing the radius of the circle.
       /// </param>
       public Circle (double radius)
       {
        if (radius <= 0) {
            throw new ArgumentOutOfRangeException("Cannot have a negative or 0 radius");
        }
        this.radius = radius;
       }

        /// <summary>
        ///     Override the <c>Object.Equals</c> method. Determines if the provided object is equal to the circle object by value comparision.
        /// </summary>
        /// <param name="obj">
        ///     An <see cref="object"/> representing the object to compare equality by value to.
        /// </param>
        /// <returns>
        ///     A <see cref="bool"/> indicating whether the circle and object are equal.
        /// </returns>
        public override bool Equals(object obj)
        {
            Circle circleB = obj as Circle;

            if (circleB != null && this.radius == circleB.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        ///     Calculates the area of circle with the currently defined radius. 
        /// </summary>
        /// <returns>
        ///     A <see cref="double"/> representing the calculated area.
        /// </returns>
        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            if (double.IsInfinity(area)) 
            {
                throw new OverflowException("Radius is too large to calculate area which is a double type");
            }
            return area;
        }
        
        /// <summary>
        ///     Calculates the perimeter of the circle with the currently defined radius. Throws an <see cref="OverflowException" /> if the radius too large.
        /// </summary>
        /// <returns>
        ///     A <see cref="double" /> representing the calculated perimiter.
        /// </returns>
        public double CalculatePerimeter()
        {
            double perimeter = Math.PI * 2 * radius;
            if (double.IsInfinity(perimeter))
            {
                throw new OverflowException("Radius too large to calculate perimeter");
            }

            return perimeter;
        }
        
        /// <summary>
        ///     Calculates the diameter of the circle with the currently defined radius.
        /// </summary>
        /// <returns>
        ///     A <see cref="double"/> representing the calculated diameter.
        /// </returns>
        public double CalculateDiameter()
        {
            double diameter = radius * 2;
            if (double.IsInfinity(diameter))
            {
                throw new OverflowException("radius is too large to calculate diameter.");
            }
            return diameter;
        }
    }

}

