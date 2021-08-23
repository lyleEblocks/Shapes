using System;


namespace RectangleShape
{
     /// <summary>
    ///     This class declares the properties of a Rectangle and underlying methods
    ///     <see cref = "double" length/>
    ///     <see cref = "const double" width/>
    /// </summary>

    public class Rectangle
    { 
        private int length;
        private int width;
        /// <summary>
        ///     This constructor instantiates the properties of the rectangle
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>

        public Rectangle(int length, int width)
        {
            if (length <= 0 || width <= 0) 
            {
                throw new ArgumentOutOfRangeException($"{nameof(width)} or {nameof(length)} cannot be 0 or negative");
            }

            this.length = length;
            this.width = width;
        }
       /// <summary>
        ///     The following method overrides the default method of Equals to allow  for objects to be equal to one and the other. 
        /// </summary>
        /// <param name="obj">is a <see cref = "obj"/> object signature</param>
        /// <returns>
        ///     A <see cref ="bool"/> returns a boolean value of true if the objects are equal
        ///     A <see cref ="bool"/> returns a boolean value of false if the objects are not equal
        /// </returns>

        public override bool Equals(object obj)
        {
            Rectangle B =  obj as Rectangle;
            
            if(B != null && this.length == B.length && this.width == B.width)
                return true;
            else
                return false;
        }
        /// <summary>
        ///     The following method calcalculates the area of a Rectangle <see cref = "double"/>
        /// </summary>
        /// <returns> 
        ///     A <see cref ="double"/> Throws an exception if length and width are negative
        ///     A <see cref ="double"/> returns a doublen value of the calculated area
        /// </returns>

        public double CalculateArea()
        {
            if(width <= 0 || length <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(width)} or {nameof(length)} cannot be 0 or negative");
            }
            return length * width;
        }
         /// <summary>
        ///     The following method calcalculates the perimeter of a Rectangle <see cref = "double"/>
        /// </summary>
        /// <returns> 
        ///     A <see cref ="double"/> Throws an exception if length and width are negative
        ///     A <see cref ="double"/> returns a doublen value of the calculated perimeter
        /// </returns>
        public double CalculatePerimeter()
        {
            if(width <= 0 || length <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(width)} or {nameof(length)} cannot be 0 or negative");
            }
            return length*2 + width*2;
        }

       public override int GetHashCode()
       {
            return base.GetHashCode();
       }
    }
}