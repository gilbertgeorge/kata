using codewars.kyu5.Car.Interfaces;

namespace codewars.kyu5.Car;

public class FuelTank : IFuelTank
{
    private double _fillLevel;
    private const int Capacity = 60;

    public FuelTank()
    {
        _fillLevel = 20;
    }
    
    public FuelTank(double level)
    {
        _fillLevel = level;
        if (_fillLevel < 0)
        {
            _fillLevel = 0;
        }
        if (_fillLevel > Capacity)
        {
            _fillLevel = Capacity;
        }
    }
    
    public double FillLevel => _fillLevel;
    public bool IsOnReserve => _fillLevel < 5;
    public bool IsComplete => _fillLevel >= Capacity;
    public void Consume(double liters)
    {
        _fillLevel -= liters;
        if (_fillLevel < 0)
        {
            _fillLevel = 0;
        }
    }

    public void Refuel(double liters)
    {
        _fillLevel += liters;
        if (_fillLevel > Capacity)
        {
            _fillLevel = Capacity;
        }
    }
}