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
    ///     This class represents a Square and its dimensions.
    /// </summary>
    public class Square
    {
        /// <summary>
        ///     A <see cref="int"/> that represents the sides of a square.
        /// </summary>
        private int sideA, sideB, sideC, sideD;

        /// <summary>
        ///     This constructor method will initialize dimension into all four sides of the square.
        /// </summary>
        /// <param name="dimension">A parameter <see cref="int"/> that represents the dimensions of the new square.</param>
        public Square(int dimension)        
        {
            if(dimension <= 0)
            {
               throw new ArgumentOutOfRangeException("All sides of the square must be a positive number.");
            }
            sideA = dimension; 
            sideB = dimension;
            sideC = dimension;
            sideD = dimension;
        }

        /// <summary>
        ///     This method will compare if two squares are equal.
        /// </summary>
        /// <param name="obj">A parameter <see cref="int"/> that represents the squares to compare.</param>
        /// <returns>A <see cref="bool"/> that is true if squares are equal and false if squares are not equal.</returns>
        public override bool Equals(object obj)
        {
           Square b = obj as Square;
           if(sideA == b.sideA && sideB == b.sideB && sideC == b.sideC && sideD == b.sideD)
           {
               return true;
           }
           else
           {
               return false;
           }
        }

        /// <summary>
        ///     This method will calculate the area of a square.
        /// </summary>
        /// <returns>Returns <see cref="int"/> that represents the area of the square.</returns>
        public int CalculateArea()
        {
            return sideA * sideB;
        }

        /// <summary>
        ///     This method will calculate the perimeter of a square.
        /// </summary>
        /// <returns>Returns <see cref="int"/> that represents the perimeter of the square.</returns>
        public int CalculatePerimeter()
        {
            return sideA * 4;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
