namespace Server.Interfaces;

public interface IUnitConverter<T> where T : struct
{
    double Convert(T from, T to, double value);
}