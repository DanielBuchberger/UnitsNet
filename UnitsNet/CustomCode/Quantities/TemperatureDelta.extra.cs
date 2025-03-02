﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

namespace UnitsNet
{
    public partial struct TemperatureDelta
    {
        /// <summary>Get <see cref="TemperatureGradient"/> from <see cref="TemperatureDelta"/> divided by <see cref="Length"/>.</summary>
        public static TemperatureGradient operator /(TemperatureDelta left, Length right)
        {
            return TemperatureGradient.FromKelvinsPerMeter(left.Kelvins / right.Meters);
        }

        /// <summary>Get <see cref="SpecificEnergy"/> from <see cref="SpecificEntropy"/> times <see cref="TemperatureDelta"/>.</summary>
        public static SpecificEnergy operator *(SpecificEntropy specificEntropy, TemperatureDelta temperatureDelta)
        {
            return SpecificEnergy.FromJoulesPerKilogram(specificEntropy.JoulesPerKilogramKelvin * temperatureDelta.Kelvins);
        }

        /// <summary>Get <see cref="SpecificEnergy"/> from <see cref="TemperatureDelta"/> times <see cref="SpecificEntropy"/>.</summary>
        public static SpecificEnergy operator *(TemperatureDelta temperatureDelta, SpecificEntropy specificEntropy)
        {
            return specificEntropy * temperatureDelta;
        }
    }
}
