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

using Xunit;

namespace Shape
{
    /// <summary>
    ///     This class will test our Sqaure class.
    /// </summary>
    public class SquareTests
    {
        [Fact]
        public void Should_Ensure_Two_Squares_Are_Equal()
        {
            // Arrange
            Square squareA = new Square(6, 6, 6, 6);
            Square squareB = new Square(6, 6, 6, 6);
            
            // Act
            bool result = squareA.Equals(squareB);

            // Assert
            Assert.True(result);
        }
    }
}
