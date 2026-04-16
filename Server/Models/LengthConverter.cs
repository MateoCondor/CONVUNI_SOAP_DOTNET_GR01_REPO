using Server.Enums;
using Server.Interfaces;

namespace Server.Models;

public class LengthConverter : IUnitConverter<LengthUnit>
{
    private static readonly Dictionary<LengthUnit, double> Factors = new()
    {
        [LengthUnit.Millimeters] = 0.001,
        [LengthUnit.Centimeters] = 0.01,
        [LengthUnit.Meters] = 1.0,
        [LengthUnit.Kilometers] = 1000.0,
        [LengthUnit.Feet] = 0.3048
    };

    public double Convert(LengthUnit from, LengthUnit to, double value)
    {
        if (value < 0) throw new ArgumentException("El valor debe ser 0 o positivo");

        if (!Factors.TryGetValue(from, out double baseFactor) || !Factors.TryGetValue(to, out double destinationFactor))
            throw new ArgumentException("Unidad no soportada.");

        return value * baseFactor / destinationFactor;
    }
}