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

namespace ShapeCircle
{   
    /// <summary>
    ///     This class declares the properties of a circle and underlying methods
    ///     <see cref = "double" radius/>
    ///     <see cref = "const double" PIE/>
    /// </summary>
    public class Circle
    {
        private double radius;
        private const double PIE = 3.14;


        /// <summary>
        ///     This constructor defines the properties of circle using the radius.
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            if (radius <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(radius)} cannot be 0 or negative");
            }
            this.radius = radius;
        }

        /// <summary>
        ///     The following method overrides the default method of Equals to allow  for objects to equal to one and other. 
        /// </summary>
        /// <param name="obj">is a <see cref = "obj"/> object signature</param>
        /// <returns>
        ///     A <see cref ="bool"/> returns a boolean value of true if the objects are equal
        ///     A <see cref ="bool"/> returns a boolean value of false if the objects are not equal
        /// </returns>
        public override bool Equals(object obj)
        {
            Circle B =  obj as Circle;
            
            if(B != null && this.radius == B.radius)
                return true;
            else
                return false;
        }
        
        public override int GetHashCode()
        {
                return base.GetHashCode();
        }
        /// <summary>
        ///     The following method calcalculates the area of a circle <see cref = "double"/>
        /// </summary>
        /// <returns> 
        ///     A <see cref ="double"/> Throws an exception if radius is negative
        ///     A <see cref ="double"/> returns a doublen value of the calculated area
        /// </returns>
        public double CalculateTheAreaOfACircle()
        {
            
            if (radius <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(radius)} cannot be 0 or negative");
            }
            double area = radius*radius*PIE;

            return area;
        }
        /// <summary>
        ///     The following method calcalculates the perimeter of a circle <see cref = "double"/>
        /// </summary>
        /// <returns> 
        ///     A <see cref ="double"/> Throws an exception if radius is negative
        ///     A <see cref ="double"/> returns a doublen value of the calculated area
        /// </returns>
        public double CalculateThePerimeterOfACircle()
        {
             if (radius <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(radius)} cannot be 0 or negative");
            }
           
            double perimeter = radius*2*PIE;
            
            return perimeter;
        }

    }
}