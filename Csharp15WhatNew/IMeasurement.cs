namespace Csharp15;

public interface IMeasurement
{
    public static double ToMeters(double centimeters) => centimeters / 100;
}