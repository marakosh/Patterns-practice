using Adapter_and_Bridge.Adapter;

CelsiusSensor celsiusSensor = new();
celsiusSensor.Temp = 30;
Adapter adapter = new();
FahrenheitSensor fahrenheitSensor = new();
adapter.GetTempInFahrenheit(celsiusSensor);