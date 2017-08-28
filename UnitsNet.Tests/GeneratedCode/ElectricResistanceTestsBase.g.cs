﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricResistance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricResistanceTestsBase
    {
        protected abstract double KiloohmsInOneOhm { get; }
        protected abstract double MegaohmsInOneOhm { get; }
        protected abstract double MilliohmsInOneOhm { get; }
        protected abstract double OhmsInOneOhm { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KiloohmsTolerance { get { return 1e-5; } }
        protected virtual double MegaohmsTolerance { get { return 1e-5; } }
        protected virtual double MilliohmsTolerance { get { return 1e-5; } }
        protected virtual double OhmsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void OhmToElectricResistanceUnits()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(KiloohmsInOneOhm, ohm.Kiloohms, KiloohmsTolerance);
            AssertEx.EqualTolerance(MegaohmsInOneOhm, ohm.Megaohms, MegaohmsTolerance);
            AssertEx.EqualTolerance(MilliohmsInOneOhm, ohm.Milliohms, MilliohmsTolerance);
            AssertEx.EqualTolerance(OhmsInOneOhm, ohm.Ohms, OhmsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricResistance.From(1, ElectricResistanceUnit.Kiloohm).Kiloohms, KiloohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.From(1, ElectricResistanceUnit.Megaohm).Megaohms, MegaohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.From(1, ElectricResistanceUnit.Milliohm).Milliohms, MilliohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.From(1, ElectricResistanceUnit.Ohm).Ohms, OhmsTolerance);
        }

        [Fact]
        public void As()
        {
            var ohm = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(KiloohmsInOneOhm, ohm.As(ElectricResistanceUnit.Kiloohm), KiloohmsTolerance);
            AssertEx.EqualTolerance(MegaohmsInOneOhm, ohm.As(ElectricResistanceUnit.Megaohm), MegaohmsTolerance);
            AssertEx.EqualTolerance(MilliohmsInOneOhm, ohm.As(ElectricResistanceUnit.Milliohm), MilliohmsTolerance);
            AssertEx.EqualTolerance(OhmsInOneOhm, ohm.As(ElectricResistanceUnit.Ohm), OhmsTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(1, ElectricResistance.FromKiloohms(ohm.Kiloohms).Ohms, KiloohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromMegaohms(ohm.Megaohms).Ohms, MegaohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromMilliohms(ohm.Milliohms).Ohms, MilliohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromOhms(ohm.Ohms).Ohms, OhmsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricResistance v = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(-1, -v.Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (ElectricResistance.FromOhms(3)-v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (ElectricResistance.FromOhms(10)/5).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, ElectricResistance.FromOhms(10)/ElectricResistance.FromOhms(5), OhmsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricResistance oneOhm = ElectricResistance.FromOhms(1);
            ElectricResistance twoOhms = ElectricResistance.FromOhms(2);

            Assert.True(oneOhm < twoOhms);
            Assert.True(oneOhm <= twoOhms);
            Assert.True(twoOhms > oneOhm);
            Assert.True(twoOhms >= oneOhm);

            Assert.False(oneOhm > twoOhms);
            Assert.False(oneOhm >= twoOhms);
            Assert.False(twoOhms < oneOhm);
            Assert.False(twoOhms <= oneOhm);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.Equal(0, ohm.CompareTo(ohm));
            Assert.True(ohm.CompareTo(ElectricResistance.Zero) > 0);
            Assert.True(ElectricResistance.Zero.CompareTo(ohm) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.Throws<ArgumentException>(() => ohm.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.Throws<ArgumentNullException>(() => ohm.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ElectricResistance a = ElectricResistance.FromOhms(1);
            ElectricResistance b = ElectricResistance.FromOhms(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ElectricResistance v = ElectricResistance.FromOhms(1);
            Assert.True(v.Equals(ElectricResistance.FromOhms(1)));
            Assert.False(v.Equals(ElectricResistance.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.False(ohm.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.False(ohm.Equals(null));
        }
    }
}
