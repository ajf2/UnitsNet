﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Acceleration, in physics, is the rate at which the velocity of an object changes over time. An object's acceleration is the net result of any and all forces acting on the object, as described by Newton's Second Law. The SI unit for acceleration is the Meter per second squared (m/s²). Accelerations are vector quantities (they have magnitude and direction) and add according to the parallelogram law. As a vector, the calculated net force is equal to the product of the object's mass (a scalar quantity) and the acceleration.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Acceleration : IComparable, IComparable<Acceleration>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Acceleration from nullable CentimetersPerSecondSquared.
        /// </summary>
        public static Acceleration? FromCentimetersPerSecondSquared(QuantityValue? centimeterspersecondsquared)
        {
            return centimeterspersecondsquared.HasValue ? FromCentimetersPerSecondSquared(centimeterspersecondsquared.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable DecimetersPerSecondSquared.
        /// </summary>
        public static Acceleration? FromDecimetersPerSecondSquared(QuantityValue? decimeterspersecondsquared)
        {
            return decimeterspersecondsquared.HasValue ? FromDecimetersPerSecondSquared(decimeterspersecondsquared.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable FeetPerSecondSquared.
        /// </summary>
        public static Acceleration? FromFeetPerSecondSquared(QuantityValue? feetpersecondsquared)
        {
            return feetpersecondsquared.HasValue ? FromFeetPerSecondSquared(feetpersecondsquared.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable InchesPerSecondSquared.
        /// </summary>
        public static Acceleration? FromInchesPerSecondSquared(QuantityValue? inchespersecondsquared)
        {
            return inchespersecondsquared.HasValue ? FromInchesPerSecondSquared(inchespersecondsquared.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable KilometersPerSecondSquared.
        /// </summary>
        public static Acceleration? FromKilometersPerSecondSquared(QuantityValue? kilometerspersecondsquared)
        {
            return kilometerspersecondsquared.HasValue ? FromKilometersPerSecondSquared(kilometerspersecondsquared.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable KnotsPerHour.
        /// </summary>
        public static Acceleration? FromKnotsPerHour(QuantityValue? knotsperhour)
        {
            return knotsperhour.HasValue ? FromKnotsPerHour(knotsperhour.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable KnotsPerMinute.
        /// </summary>
        public static Acceleration? FromKnotsPerMinute(QuantityValue? knotsperminute)
        {
            return knotsperminute.HasValue ? FromKnotsPerMinute(knotsperminute.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable KnotsPerSecond.
        /// </summary>
        public static Acceleration? FromKnotsPerSecond(QuantityValue? knotspersecond)
        {
            return knotspersecond.HasValue ? FromKnotsPerSecond(knotspersecond.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable MetersPerSecondSquared.
        /// </summary>
        public static Acceleration? FromMetersPerSecondSquared(QuantityValue? meterspersecondsquared)
        {
            return meterspersecondsquared.HasValue ? FromMetersPerSecondSquared(meterspersecondsquared.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable MicrometersPerSecondSquared.
        /// </summary>
        public static Acceleration? FromMicrometersPerSecondSquared(QuantityValue? micrometerspersecondsquared)
        {
            return micrometerspersecondsquared.HasValue ? FromMicrometersPerSecondSquared(micrometerspersecondsquared.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable MillimetersPerSecondSquared.
        /// </summary>
        public static Acceleration? FromMillimetersPerSecondSquared(QuantityValue? millimeterspersecondsquared)
        {
            return millimeterspersecondsquared.HasValue ? FromMillimetersPerSecondSquared(millimeterspersecondsquared.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable NanometersPerSecondSquared.
        /// </summary>
        public static Acceleration? FromNanometersPerSecondSquared(QuantityValue? nanometerspersecondsquared)
        {
            return nanometerspersecondsquared.HasValue ? FromNanometersPerSecondSquared(nanometerspersecondsquared.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Get nullable Acceleration from nullable StandardGravity.
        /// </summary>
        public static Acceleration? FromStandardGravity(QuantityValue? standardgravity)
        {
            return standardgravity.HasValue ? FromStandardGravity(standardgravity.Value) : default(Acceleration?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AccelerationUnit" /> to <see cref="Acceleration" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Acceleration unit value.</returns>
        public static Acceleration? From(QuantityValue? value, AccelerationUnit fromUnit)
        {
            return value.HasValue ? new Acceleration((double)value.Value, fromUnit) : default(Acceleration?);
        }

        #endregion

        #region Arithmetic Operators

        public static Acceleration operator -(Acceleration right)
        {
            return new Acceleration(-right.Value, right.Unit);
        }

        public static Acceleration operator +(Acceleration left, Acceleration right)
        {
            return new Acceleration(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Acceleration operator -(Acceleration left, Acceleration right)
        {
            return new Acceleration(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Acceleration operator *(double left, Acceleration right)
        {
            return new Acceleration(left * right.Value, right.Unit);
        }

        public static Acceleration operator *(Acceleration left, double right)
        {
            return new Acceleration(left.Value * right, left.Unit);
        }

        public static Acceleration operator /(Acceleration left, double right)
        {
            return new Acceleration(left.Value / right, left.Unit);
        }

        public static double operator /(Acceleration left, Acceleration right)
        {
            return left.MetersPerSecondSquared / right.MetersPerSecondSquared;
        }

        #endregion

        public static bool operator <=(Acceleration left, Acceleration right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Acceleration left, Acceleration right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Acceleration left, Acceleration right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Acceleration left, Acceleration right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Acceleration left, Acceleration right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Acceleration left, Acceleration right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}