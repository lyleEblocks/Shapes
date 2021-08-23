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
    ///     Represents a square and inherits fields and methods from the <see cref="Rectangle"> class.
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        ///     Initialises a new instance of the <see cref="Square" /> class with its side length.
        /// </summary>
        /// <param name="length">
        ///     A <see cref="double" /> representing the length of the sides of the square.
        /// </param>
        public Square(double length) : base (length, length) { }
    }
}