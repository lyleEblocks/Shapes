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
using CalculationsSpace;


namespace SquareShape
{
    
    /// <summary>
    ///     This class inherits from the abstract class calculation and provides the implemnation for its methods along with the propoerties it makes use of
    /// </summary>

    public class Square : Calculations
    {
        private double side, area, perimeter;

        /// <summary>
        ///     This Constructor takes the side as a parameter and instantiates the properties of the square class
        /// </summary>
        /// <param name="side"></param>
        public Square(double side)
        {
             if (side <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(side)} cannot be 0 or negative");
            }

            this.side = side;
        }

        /// <summary>
        ///     This is an override method that provides implementation for the CalculateAreaOfaSquare method <see cref = "double" /> 
        /// </summary>
        /// <returns>
        ///     A <see cref = "double" /> returns the calculated area if a positive side value was supplied
        /// </returns>
        public override double CalculateArea()
        {
            if (side <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(side)} cannot be 0 or negative");
            }
            area = side*side;

            return area;
        }

        /// <summary>
        ///     This is an override method that provides implementation for the CalculatePerimeterOfaSquare method <see cref = "double" /> 
        /// </summary>
        /// <returns>
        ///     A <see cref = "double" /> returns the calculated Perimeter if a positive side value was supplied
        /// </returns>
        public override double  CalculatePerimeter()
        {
            if (side <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(side)} cannot be 0 or negative");
            }
            perimeter = side*4;

            return perimeter;
        }

        /// <summary>
        ///     This is an override method that provides implementation for the default Equals method <see cref = "obj" /> 
        /// </summary>
        /// <param name = "obj"> nis a <see cref= "obj"/> object signature<param/>
        /// <returns>
        ///     A <see cref = "bool" /> returns a boolean value of true if the sides are equal or false if the sides are not equal.
        /// </returns>
        public override bool Equals(object obj)
        {
            Square B =  obj as Square;
            
            if(B != null && this.side == B.side)
                return true;
            else
                return false;
        }
        
        /// <Inheritdoc>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
