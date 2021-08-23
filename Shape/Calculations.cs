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

namespace CalculationsSpace
{
    /// <summary>
    ///     This class provides the definition for the calculation methods <see cref = "double"/>, CalculateArea() and CalculatePerimeter() for the Square, Circle and Rectangle class.
    /// </summary>
    public abstract class Calculations
    {
        abstract public double CalculateArea();

        abstract public double CalculatePerimeter();
    }
}