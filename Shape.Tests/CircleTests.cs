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
    ///     Provides Testing for the Circle Class.
    /// </summary>
    public class CircleTests
    {
        /// <summary>
        ///     Tests that two circles are equal successfully.
        /// </summary>
        [Fact]
        public void Should_Ensure_The_Two_Circles_Are_Equal()
        {
            //Arrange
            Circle circle1 = new Circle(12);
            Circle circle2 = new Circle(12);

            //Act
            bool circle_are_equal = circle1.Equals(circle2);

            //Arrange
            Assert.True(circle_are_equal);
        }

        /// <summary>
        ///     Tests that two circles are unequal successfully.
        /// </summary>
        [Fact]
        public void Should_Ensure_The_Two_Circles_Are_Not_Equal()
        {
            //Arrange
            Circle circle1 = new Circle(3);
            Circle circle2 = new Circle(12);

            //Act
            bool circle_are_not_equal = circle1.Equals(circle2);

            //Arrange
            Assert.False(circle_are_not_equal);
        }

        /// <summary>
        ///     Tests that an exception is thrown when the radius of the circle is less than or equal to 0.
        /// </summary>
        [Fact]
        public void Should_Ensure_Circle_Throws_Exception()
        {
            //  Arrange
            //  Act
            //  Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            { 
                Circle circle1 = new Circle(-15);
            });          
        }

        /// <summary>
        ///     Tests that the calculation of the circle area is done successfully.
        /// </summary>
        [Fact]
        public void Calculate_Area_Of_Circle_Successfully()
        {
            // Arrange
            Circle circle = new Circle(10);

            // Act
            double result = circle.CalculateArea();

            // Assert
            Assert.Equal(98.69604401089359, result);
        }

        /// <summary>
        ///     Tests that the calculation of the circle circumference is done succesfully. 
        /// </summary>
        [Fact]
        public void Calculate_Circumference_Of_Circle_Successfully()
        {
            // Arrange
            Circle circle = new Circle(10);

            // Act
            double result = circle.CalculateCircumference();

            // Assert
            Assert.Equal(62.83185307179586 , result);
        }

        /// <summary>
        ///     Tests that the calculation of the circle diameter is done successfully. 
        /// </summary>
        [Fact]
        public void Calculate_Diameter_Of_Circle_Successfully()
        {
            // Arrange
            Circle circle = new Circle(10);

            // Act
            double result = circle.CalculateDiameter();

            // Assert
            Assert.Equal(20, result);
        }
    }
}