using codewars.kyu5.Car.Interfaces;

namespace codewars.kyu5.Car;

public class Engine : IEngine
{
    private bool _isRunning;
    private readonly IFuelTank _fuelTank;
    
    public Engine(IFuelTank fuelTank)
    {
        _isRunning = false;
        _fuelTank = fuelTank;
    }

    public bool IsRunning => _isRunning;
    public void Consume(double liters)
    {
        if (_isRunning)
        {
            _fuelTank.Consume(liters);
        }
        if (_fuelTank.FillLevel <= 0)
        {
            _isRunning = false;
        }
    }

    public void Start()
    {
        if (_fuelTank.FillLevel > 0)
        {
            _isRunning = true;
        }
    }

    public void Stop()
    {
        _isRunning = false;
    }
}