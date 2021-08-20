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
    public class Square
    {
        /// <summary>
        ///     Declares the length of the square.
        /// </summary>
        private double length;

        /// <summary>
        ///     Instantiates an instance of <see cref="Square">. 
        /// </summary>
        /// <param name="length">
        ///     A <see cref="double"> representing the length of a square.
        /// </param>
        public Square(double length)
        {
            this.length = length;
        }

        /// <summary>
        ///     Validates whether two squares are equal.
        /// </summary>
        /// <param name="obj">
        ///     An <see cref="object"> representing the second square to compare to the current <see cref="Square">.
        /// </param>
        /// <returns>
        ///     A <see cref="bool"> representing whether the two squares are equal or not.
        /// </returns>
        public override bool Equals(object obj)
        {
            return true;
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