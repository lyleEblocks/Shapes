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
    ///     Provides multiple square calculation functions.
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        ///     Instantiates an instance of a square.
        /// </summary>
        /// <param name="length">
        ///     A <see cref="double"> representing the length of the the square.
        /// </param>
        public Square(double length) : base(length, length)
        {
        }

        /// <summary>
        ///     Calculates the perimeter of a square.
        /// </summary>
        /// <returns>
        ///     A <see cref="double"> representing the perimeter of the square.
        /// </returns>
        public double CalculatePerimeter()
        {
            return Length*4;
        }
    }
}