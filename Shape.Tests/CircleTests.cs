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
    ///     This Test class will test the Circle class methods.
    /// </summary>
    public class CircleTests
    {
        [Fact]
        /// <summary>
        ///     Tests that a new Circle instance initialises successfully.
        /// </summary>
        public void Should_Instantiate_Circle_Successfully()
        {
            //Arrange
            
            //Act
            Circle circle = new Circle(8);

            //Assert
            Assert.NotNull(circle);
        }

        [Fact]
        /// <summary>
        ///     Tests that two circles are equal.
        /// </summary>
        public void Should_Ensure_The_Two_Are_Equal()
        {
            //Arrange
            Circle circleA = new Circle (9);
            Circle circleB = new Circle (9);

            //Act
            bool result = circleA.Equals(circleB);

            //Assert
            Assert.True(result);

        }

        [Fact]
        /// <summary>
        ///     Tests that two circles are not equal.
        /// </summary>
        public void Should_Ensure_The_Two_Are_Not_Equal()
        {
            //Arrage
            Circle circleA = new Circle(9);
            Circle circleB = new Circle(10);

            //Act
            bool result = circleA.Equals(circleB);
            
            //Assert
            Assert.False(result);
        }

        [Fact]
        /// <summary>
        ///     Tests that the radius is not negative and throws an exception if it is negative.
        /// </summary>
        public void Should_Ensure_Radius_Not_Negative_Throws_Exception()
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                Circle circleA = new Circle(-10);
            });
        }

        [Fact]
        /// <summary>
        ///     Tests that the area is calculated correctly.
        /// </summary>
        public void Should_Calculate_Area_Circle_Successfully()
        {
            //Arrange
            Circle circle = new Circle(5);
            double expectedArea = 5 * 5 * Math.PI;

            //Act
            double resultArea = circle.CalculateArea();

            //Assert
            Assert.Equal(expectedArea, resultArea);
        }

        [Fact]
        /// <summary>
        ///     Tests that an exception is thrown if the defined radius is too large to calculate area.
        /// </summary>
        public void Calculate_Area_Circle_Exception()
        {
            //Arange
            //Act
            //Assert
            Assert.Throws<OverflowException>(() => {
                Circle circle = new Circle(Double.MaxValue);
                double result = circle.CalculateArea();
            });
        }

        [Fact]
        /// <summary>
        ///    Tests that perimeter of a circle is calculated successfully.
        /// </summary>
        public void Calculate_Perimeter_Successfully()
        {
            // Arrange
            Circle circle = new Circle(5);
            double expected = Math.PI * 2 * 5;

            // Act
            double result = circle.CalculatePerimeter();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        /// <summary>
        ///     Tests that an exception is thrown if diameter is too big to store.
        /// </summary>
        public void Calculate_Perimeter_Exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<OverflowException>( () => 
            {
                Circle circle = new Circle(double.MaxValue);

                circle.CalculatePerimeter();
            });
        }

        [Fact]
        /// <summary>
        ///     Tests that diameter is calculated successfully.
        /// </summary>
        public void Calculate_Diameter_Successfully()
        {
            //Arrange
            Circle circle = new Circle(5);
            double expected = 10;

            //Act
            double result = circle.CalculateDiameter();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        /// <summary>
        ///     Tests that an exception is thrown if the defined radius is too large to calculate diameter.
        /// </summary>
        public void Calculate_Diameter_ThrowOverflowException()
        {
            // Arrange
            Circle circle = new Circle(double.MaxValue);

            // Act
            // Assert
            Assert.Throws<OverflowException>(() => circle.CalculateDiameter());
        }
    }

}