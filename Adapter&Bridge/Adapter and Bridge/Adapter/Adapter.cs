using Adapter_and_Bridge.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_and_Bridge.Adapter;

public class FahrenheitSensor
{
    public double FTemp { get; set; }
}

public class CelsiusSensor
{
    public double Temp { get; set; }
}

public class Adapter : CelsiusSensor
{
    FahrenheitSensor fahrenheitSensor = new();
    public void GetTempInFahrenheit(CelsiusSensor celsiusSensor)
    {
        fahrenheitSensor.FTemp = ((celsiusSensor.Temp * 9.0 / 5.0) + 32);
        Console.WriteLine($"{celsiusSensor.Temp} Celsius equals {fahrenheitSensor.FTemp} in Farenheit");
    }
}
