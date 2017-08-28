function GenerateUnitTestBaseClassSourceCode($unitClass)
{
    $className = $unitClass.Name;
    $baseType = $unitClass.BaseType;
    $units = $unitClass.Units;
    $baseUnit = $units | where { $_.SingularName -eq $unitClass.BaseUnit }
    $baseUnitPluralName = $baseUnit.PluralName
    $baseUnitVariableName = $baseUnit.SingularName.ToLowerInvariant();
    $unitEnumName = "$($className)Unit";

@"
//------------------------------------------------------------------------------
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
    /// Test of $className.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class $($className)TestsBase
    {
"@;    foreach ($unit in $units) {@"
        protected abstract double $($unit.PluralName)InOne$($baseUnit.SingularName) { get; }
"@; }@"

// ReSharper disable VirtualMemberNeverOverriden.Global
"@;    foreach ($unit in $units) {@"
        protected virtual double $($unit.PluralName)Tolerance { get { return 1e-5; } }
"@; }@"
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void $($baseUnit.SingularName)To$($className)Units()
        {
            $className $baseUnitVariableName = $className.From$baseUnitPluralName(1);
"@; foreach ($unit in $units) {@"
            AssertEx.EqualTolerance($($unit.PluralName)InOne$($baseUnit.SingularName), $baseUnitVariableName.$($unit.PluralName), $($unit.PluralName)Tolerance);
"@; }@"
        }

        [Fact]
        public void FromValueAndUnit()
        {
"@; foreach ($unit in $units) {@"
            AssertEx.EqualTolerance(1, $className.From(1, $unitEnumName.$($unit.SingularName)).$($unit.PluralName), $($unit.PluralName)Tolerance);
"@; }@"
        }

        [Fact]
        public void As()
        {
            var $baseUnitVariableName = $className.From$baseUnitPluralName(1);
"@; foreach ($unit in $units) {@"
            AssertEx.EqualTolerance($($unit.PluralName)InOne$($baseUnit.SingularName), $baseUnitVariableName.As($($className)Unit.$($unit.SingularName)), $($unit.PluralName)Tolerance);
"@; }@"
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            $className $baseUnitVariableName = $className.From$baseUnitPluralName(1);
"@; foreach ($unit in $units) {@"
            AssertEx.EqualTolerance(1, $className.From$($unit.PluralName)($baseUnitVariableName.$($unit.PluralName)).$baseUnitPluralName, $($unit.PluralName)Tolerance);
"@; }@"
        }

"@; if ($unitClass.Logarithmic -eq $true) {@"
        [Fact]
        public void LogarithmicArithmeticOperators()
        {
            $className v = $className.From$baseUnitPluralName(40);
            AssertEx.EqualTolerance(-40, -v.$baseUnitPluralName, $($unit.PluralName)Tolerance);
            AssertLogarithmicAddition();
            AssertLogarithmicSubtraction();
            AssertEx.EqualTolerance(50, (v*10).$baseUnitPluralName, $($unit.PluralName)Tolerance);
            AssertEx.EqualTolerance(50, (10*v).$baseUnitPluralName, $($unit.PluralName)Tolerance);
            AssertEx.EqualTolerance(35, (v/5).$baseUnitPluralName, $($unit.PluralName)Tolerance);
            AssertEx.EqualTolerance(35, v/$className.From$baseUnitPluralName(5), $($unit.PluralName)Tolerance);
        }

        protected abstract void AssertLogarithmicAddition();

        protected abstract void AssertLogarithmicSubtraction();

"@; }
    elseif ($unitClass.GenerateArithmetic -eq $true) {@"
        [Fact]
        public void ArithmeticOperators()
        {
            $className v = $className.From$baseUnitPluralName(1);
            AssertEx.EqualTolerance(-1, -v.$baseUnitPluralName, $($baseUnit.PluralName)Tolerance);
            AssertEx.EqualTolerance(2, ($className.From$baseUnitPluralName(3)-v).$baseUnitPluralName, $($baseUnit.PluralName)Tolerance);
            AssertEx.EqualTolerance(2, (v + v).$baseUnitPluralName, $($baseUnit.PluralName)Tolerance);
            AssertEx.EqualTolerance(10, (v*10).$baseUnitPluralName, $($baseUnit.PluralName)Tolerance);
            AssertEx.EqualTolerance(10, (10*v).$baseUnitPluralName, $($baseUnit.PluralName)Tolerance);
            AssertEx.EqualTolerance(2, ($className.From$baseUnitPluralName(10)/5).$baseUnitPluralName, $($baseUnit.PluralName)Tolerance);
            AssertEx.EqualTolerance(2, $className.From$baseUnitPluralName(10)/$className.From$baseUnitPluralName(5), $($baseUnit.PluralName)Tolerance);
        }
"@; }@"

        [Fact]
        public void ComparisonOperators()
        {
            $className one$($baseUnit.SingularName) = $className.From$baseUnitPluralName(1);
            $className two$baseUnitPluralName = $className.From$baseUnitPluralName(2);

            Assert.True(one$($baseUnit.SingularName) < two$baseUnitPluralName);
            Assert.True(one$($baseUnit.SingularName) <= two$baseUnitPluralName);
            Assert.True(two$baseUnitPluralName > one$($baseUnit.SingularName));
            Assert.True(two$baseUnitPluralName >= one$($baseUnit.SingularName));

            Assert.False(one$($baseUnit.SingularName) > two$baseUnitPluralName);
            Assert.False(one$($baseUnit.SingularName) >= two$baseUnitPluralName);
            Assert.False(two$baseUnitPluralName < one$($baseUnit.SingularName));
            Assert.False(two$baseUnitPluralName <= one$($baseUnit.SingularName));
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            $className $baseUnitVariableName = $className.From$baseUnitPluralName(1);
            Assert.Equal(0, $baseUnitVariableName.CompareTo($baseUnitVariableName));
            Assert.True($baseUnitVariableName.CompareTo($className.Zero) > 0);
            Assert.True($className.Zero.CompareTo($baseUnitVariableName) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            $className $baseUnitVariableName = $className.From$baseUnitPluralName(1);
            Assert.Throws<ArgumentException>(() => $baseUnitVariableName.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            $className $baseUnitVariableName = $className.From$baseUnitPluralName(1);
            Assert.Throws<ArgumentNullException>(() => $baseUnitVariableName.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            $className a = $className.From$baseUnitPluralName(1);
            $className b = $className.From$baseUnitPluralName(2);

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
            $className v = $className.From$baseUnitPluralName(1);
            Assert.True(v.Equals($className.From$baseUnitPluralName(1)));
            Assert.False(v.Equals($className.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            $className $baseUnitVariableName = $className.From$baseUnitPluralName(1);
            Assert.False($baseUnitVariableName.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            $className $baseUnitVariableName = $className.From$baseUnitPluralName(1);
            Assert.False($baseUnitVariableName.Equals(null));
        }
    }
}
"@;
}
