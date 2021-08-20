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

namespace Shape
{
    public class Square
    {
        private int sideA, sideB, sideC, sideD;
        public Square(int a, int b, int c, int d)        
        {
            sideA = a;
            sideB = b;
            sideC = c;
            sideD = d;
        }

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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
