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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// Windows Runtime Component does not support CultureInfo type, so use culture name string instead for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Molar concentration, also called molarity, amount concentration or substance concentration, is a measure of the concentration of a solute in a solution, or of any chemical species, in terms of amount of substance in a given volume. 
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Molarity
#else
    public partial struct Molarity : IComparable, IComparable<Molarity>
#endif
    {
        /// <summary>
        ///     Base unit of Molarity.
        /// </summary>
        private readonly double _molesPerCubicMeter;

		// Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public Molarity() : this(0)
        {
        }
#endif

        public Molarity(double molespercubicmeter)
        {
            _molesPerCubicMeter = Convert.ToDouble(molespercubicmeter);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        private
#else
        public
#endif
        Molarity(long molespercubicmeter)
        {
            _molesPerCubicMeter = Convert.ToDouble(molespercubicmeter);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
#if WINDOWS_UWP
        private
#else
        public
#endif
        Molarity(decimal molespercubicmeter)
        {
            _molesPerCubicMeter = Convert.ToDouble(molespercubicmeter);
        }

        #region Properties

		/// <summary>
		///     The <see cref="QuantityType" /> of this quantity.
		/// </summary>
        public static QuantityType QuantityType => QuantityType.Molarity;

		/// <summary>
		///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
		/// </summary>
        public static MolarityUnit BaseUnit
        {
            get { return MolarityUnit.MolesPerCubicMeter; }
        }

        /// <summary>
        ///     All units of measurement for the Molarity quantity.
        /// </summary>
        public static MolarityUnit[] Units { get; } = Enum.GetValues(typeof(MolarityUnit)).Cast<MolarityUnit>().ToArray();

        /// <summary>
        ///     Get Molarity in CentimolesPerLiter.
        /// </summary>
        public double CentimolesPerLiter
        {
            get { return (_molesPerCubicMeter*1e-3) / 1e-2d; }
        }

        /// <summary>
        ///     Get Molarity in DecimolesPerLiter.
        /// </summary>
        public double DecimolesPerLiter
        {
            get { return (_molesPerCubicMeter*1e-3) / 1e-1d; }
        }

        /// <summary>
        ///     Get Molarity in MicromolesPerLiter.
        /// </summary>
        public double MicromolesPerLiter
        {
            get { return (_molesPerCubicMeter*1e-3) / 1e-6d; }
        }

        /// <summary>
        ///     Get Molarity in MillimolesPerLiter.
        /// </summary>
        public double MillimolesPerLiter
        {
            get { return (_molesPerCubicMeter*1e-3) / 1e-3d; }
        }

        /// <summary>
        ///     Get Molarity in MolesPerCubicMeter.
        /// </summary>
        public double MolesPerCubicMeter
        {
            get { return _molesPerCubicMeter; }
        }

        /// <summary>
        ///     Get Molarity in MolesPerLiter.
        /// </summary>
        public double MolesPerLiter
        {
            get { return _molesPerCubicMeter*1e-3; }
        }

        /// <summary>
        ///     Get Molarity in NanomolesPerLiter.
        /// </summary>
        public double NanomolesPerLiter
        {
            get { return (_molesPerCubicMeter*1e-3) / 1e-9d; }
        }

        /// <summary>
        ///     Get Molarity in PicomolesPerLiter.
        /// </summary>
        public double PicomolesPerLiter
        {
            get { return (_molesPerCubicMeter*1e-3) / 1e-12d; }
        }

        #endregion

        #region Static

        public static Molarity Zero
        {
            get { return new Molarity(); }
        }

        /// <summary>
        ///     Get Molarity from CentimolesPerLiter.
        /// </summary>
        public static Molarity FromCentimolesPerLiter(double centimolesperliter)
        {
            return new Molarity((centimolesperliter/1e-3) * 1e-2d);
        }

        /// <summary>
        ///     Get Molarity from DecimolesPerLiter.
        /// </summary>
        public static Molarity FromDecimolesPerLiter(double decimolesperliter)
        {
            return new Molarity((decimolesperliter/1e-3) * 1e-1d);
        }

        /// <summary>
        ///     Get Molarity from MicromolesPerLiter.
        /// </summary>
        public static Molarity FromMicromolesPerLiter(double micromolesperliter)
        {
            return new Molarity((micromolesperliter/1e-3) * 1e-6d);
        }

        /// <summary>
        ///     Get Molarity from MillimolesPerLiter.
        /// </summary>
        public static Molarity FromMillimolesPerLiter(double millimolesperliter)
        {
            return new Molarity((millimolesperliter/1e-3) * 1e-3d);
        }

        /// <summary>
        ///     Get Molarity from MolesPerCubicMeter.
        /// </summary>
        public static Molarity FromMolesPerCubicMeter(double molespercubicmeter)
        {
            return new Molarity(molespercubicmeter);
        }

        /// <summary>
        ///     Get Molarity from MolesPerLiter.
        /// </summary>
        public static Molarity FromMolesPerLiter(double molesperliter)
        {
            return new Molarity(molesperliter/1e-3);
        }

        /// <summary>
        ///     Get Molarity from NanomolesPerLiter.
        /// </summary>
        public static Molarity FromNanomolesPerLiter(double nanomolesperliter)
        {
            return new Molarity((nanomolesperliter/1e-3) * 1e-9d);
        }

        /// <summary>
        ///     Get Molarity from PicomolesPerLiter.
        /// </summary>
        public static Molarity FromPicomolesPerLiter(double picomolesperliter)
        {
            return new Molarity((picomolesperliter/1e-3) * 1e-12d);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable Molarity from nullable CentimolesPerLiter.
        /// </summary>
        public static Molarity? FromCentimolesPerLiter(double? centimolesperliter)
        {
            if (centimolesperliter.HasValue)
            {
                return FromCentimolesPerLiter(centimolesperliter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Molarity from nullable DecimolesPerLiter.
        /// </summary>
        public static Molarity? FromDecimolesPerLiter(double? decimolesperliter)
        {
            if (decimolesperliter.HasValue)
            {
                return FromDecimolesPerLiter(decimolesperliter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Molarity from nullable MicromolesPerLiter.
        /// </summary>
        public static Molarity? FromMicromolesPerLiter(double? micromolesperliter)
        {
            if (micromolesperliter.HasValue)
            {
                return FromMicromolesPerLiter(micromolesperliter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Molarity from nullable MillimolesPerLiter.
        /// </summary>
        public static Molarity? FromMillimolesPerLiter(double? millimolesperliter)
        {
            if (millimolesperliter.HasValue)
            {
                return FromMillimolesPerLiter(millimolesperliter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Molarity from nullable MolesPerCubicMeter.
        /// </summary>
        public static Molarity? FromMolesPerCubicMeter(double? molespercubicmeter)
        {
            if (molespercubicmeter.HasValue)
            {
                return FromMolesPerCubicMeter(molespercubicmeter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Molarity from nullable MolesPerLiter.
        /// </summary>
        public static Molarity? FromMolesPerLiter(double? molesperliter)
        {
            if (molesperliter.HasValue)
            {
                return FromMolesPerLiter(molesperliter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Molarity from nullable NanomolesPerLiter.
        /// </summary>
        public static Molarity? FromNanomolesPerLiter(double? nanomolesperliter)
        {
            if (nanomolesperliter.HasValue)
            {
                return FromNanomolesPerLiter(nanomolesperliter.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Molarity from nullable PicomolesPerLiter.
        /// </summary>
        public static Molarity? FromPicomolesPerLiter(double? picomolesperliter)
        {
            if (picomolesperliter.HasValue)
            {
                return FromPicomolesPerLiter(picomolesperliter.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarityUnit" /> to <see cref="Molarity" />.
        /// </summary>
        /// <param name="val">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Molarity unit value.</returns>
        public static Molarity From(double val, MolarityUnit fromUnit)
        {
            switch (fromUnit)
            {
                case MolarityUnit.CentimolesPerLiter:
                    return FromCentimolesPerLiter(val);
                case MolarityUnit.DecimolesPerLiter:
                    return FromDecimolesPerLiter(val);
                case MolarityUnit.MicromolesPerLiter:
                    return FromMicromolesPerLiter(val);
                case MolarityUnit.MillimolesPerLiter:
                    return FromMillimolesPerLiter(val);
                case MolarityUnit.MolesPerCubicMeter:
                    return FromMolesPerCubicMeter(val);
                case MolarityUnit.MolesPerLiter:
                    return FromMolesPerLiter(val);
                case MolarityUnit.NanomolesPerLiter:
                    return FromNanomolesPerLiter(val);
                case MolarityUnit.PicomolesPerLiter:
                    return FromPicomolesPerLiter(val);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarityUnit" /> to <see cref="Molarity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Molarity unit value.</returns>
        public static Molarity? From(double? value, MolarityUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case MolarityUnit.CentimolesPerLiter:
                    return FromCentimolesPerLiter(value.Value);
                case MolarityUnit.DecimolesPerLiter:
                    return FromDecimolesPerLiter(value.Value);
                case MolarityUnit.MicromolesPerLiter:
                    return FromMicromolesPerLiter(value.Value);
                case MolarityUnit.MillimolesPerLiter:
                    return FromMillimolesPerLiter(value.Value);
                case MolarityUnit.MolesPerCubicMeter:
                    return FromMolesPerCubicMeter(value.Value);
                case MolarityUnit.MolesPerLiter:
                    return FromMolesPerLiter(value.Value);
                case MolarityUnit.NanomolesPerLiter:
                    return FromNanomolesPerLiter(value.Value);
                case MolarityUnit.PicomolesPerLiter:
                    return FromPicomolesPerLiter(value.Value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MolarityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MolarityUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static Molarity operator -(Molarity right)
        {
            return new Molarity(-right._molesPerCubicMeter);
        }

        public static Molarity operator +(Molarity left, Molarity right)
        {
            return new Molarity(left._molesPerCubicMeter + right._molesPerCubicMeter);
        }

        public static Molarity operator -(Molarity left, Molarity right)
        {
            return new Molarity(left._molesPerCubicMeter - right._molesPerCubicMeter);
        }

        public static Molarity operator *(double left, Molarity right)
        {
            return new Molarity(left*right._molesPerCubicMeter);
        }

        public static Molarity operator *(Molarity left, double right)
        {
            return new Molarity(left._molesPerCubicMeter*(double)right);
        }

        public static Molarity operator /(Molarity left, double right)
        {
            return new Molarity(left._molesPerCubicMeter/(double)right);
        }

        public static double operator /(Molarity left, Molarity right)
        {
            return Convert.ToDouble(left._molesPerCubicMeter/right._molesPerCubicMeter);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is Molarity)) throw new ArgumentException("Expected type Molarity.", "obj");
            return CompareTo((Molarity) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Molarity other)
        {
            return _molesPerCubicMeter.CompareTo(other._molesPerCubicMeter);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(Molarity left, Molarity right)
        {
            return left._molesPerCubicMeter <= right._molesPerCubicMeter;
        }

        public static bool operator >=(Molarity left, Molarity right)
        {
            return left._molesPerCubicMeter >= right._molesPerCubicMeter;
        }

        public static bool operator <(Molarity left, Molarity right)
        {
            return left._molesPerCubicMeter < right._molesPerCubicMeter;
        }

        public static bool operator >(Molarity left, Molarity right)
        {
            return left._molesPerCubicMeter > right._molesPerCubicMeter;
        }

        public static bool operator ==(Molarity left, Molarity right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._molesPerCubicMeter == right._molesPerCubicMeter;
        }

        public static bool operator !=(Molarity left, Molarity right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._molesPerCubicMeter != right._molesPerCubicMeter;
        }
#endif

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _molesPerCubicMeter.Equals(((Molarity) obj)._molesPerCubicMeter);
        }

        public override int GetHashCode()
        {
            return _molesPerCubicMeter.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(MolarityUnit unit)
        {
            switch (unit)
            {
                case MolarityUnit.CentimolesPerLiter:
                    return CentimolesPerLiter;
                case MolarityUnit.DecimolesPerLiter:
                    return DecimolesPerLiter;
                case MolarityUnit.MicromolesPerLiter:
                    return MicromolesPerLiter;
                case MolarityUnit.MillimolesPerLiter:
                    return MillimolesPerLiter;
                case MolarityUnit.MolesPerCubicMeter:
                    return MolesPerCubicMeter;
                case MolarityUnit.MolesPerLiter:
                    return MolesPerLiter;
                case MolarityUnit.NanomolesPerLiter:
                    return NanomolesPerLiter;
                case MolarityUnit.PicomolesPerLiter:
                    return PicomolesPerLiter;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Molarity Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Molarity Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return QuantityParser.Parse<Molarity, MolarityUnit>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    MolarityUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromMolesPerCubicMeter(x.MolesPerCubicMeter + y.MolesPerCubicMeter));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Molarity result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out Molarity result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(Molarity);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MolarityUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MolarityUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static MolarityUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<MolarityUnit>(str.Trim());

            if (unit == MolarityUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized MolarityUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is MolesPerCubicMeter
        /// </summary>
        public static MolarityUnit ToStringDefaultUnit { get; set; } = MolarityUnit.MolesPerCubicMeter;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(ToStringDefaultUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(MolarityUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(MolarityUnit unit, [CanBeNull] Culture culture)
        {
            return ToString(unit, culture, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(MolarityUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, culture, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(MolarityUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, formatProvider, args);
            return string.Format(formatProvider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of Molarity
        /// </summary>
        public static Molarity MaxValue
        {
            get
            {
                return new Molarity(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of Molarity
        /// </summary>
        public static Molarity MinValue
        {
            get
            {
                return new Molarity(double.MinValue);
            }
        }
    }
}
