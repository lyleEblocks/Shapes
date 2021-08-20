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
using Xunit;

namespace Shape.Tests
{
    /// <summary>
    ///     Provides Testing for the <see cref="Square"> Class.
    /// </summary>
    public class SquareTests
    {
        /// <summary>
        ///     Tests that two squares are equal successfully.
        /// </summary>
        [Fact]
        public void Should_Ensure_The_Two_Squares_Are_Equal()
        {
            //Arrange
            Square square1 = new Square(12);
            Square square2 = new Square(12);

            //Act
            bool squares_are_equal = square1.Equals(square2);

            //Arrange
            Assert.True(squares_are_equal);
        }
    }
}