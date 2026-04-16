using Server.Enums;
using Server.Interfaces;

namespace Server.Models;

public class MassConverter : IUnitConverter<MassUnit>
{
    private static readonly Dictionary<MassUnit, double> Factors = new()
    {
        [MassUnit.Milligrams] = 0.001,
        [MassUnit.Grams] = 1.0,
        [MassUnit.Kilograms] = 1000.0,
        [MassUnit.Pounds] = 453.592,
        [MassUnit.Ounces] = 28.3495
    };
    public double Convert(MassUnit from, MassUnit to, double value)
    {
        if (value < 0) throw new ArgumentException("El valor debe ser 0 o positivo");

        if (!Factors.TryGetValue(from, out double baseFactor) || !Factors.TryGetValue(to, out double destinationFactor))
            throw new ArgumentException("Unidad no soportada.");

        return value * baseFactor / destinationFactor;
    }
}