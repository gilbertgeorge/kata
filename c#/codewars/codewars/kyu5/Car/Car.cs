using codewars.kyu5.Car.Interfaces;

namespace codewars.kyu5.Car;

public class Car : ICar
{
    public IFuelTankDisplay fuelTankDisplay;
    private readonly IEngine _engine;
    private readonly IFuelTank _fuelTank;

    public Car()
    {
        _fuelTank = new FuelTank();
        _engine = new Engine(_fuelTank);
        fuelTankDisplay = new FuelTankDisplay(_fuelTank);
    }

    public Car(double fuelLevel)
    {
        _fuelTank = new FuelTank(fuelLevel);
        _engine = new Engine(_fuelTank);
        fuelTankDisplay = new FuelTankDisplay(_fuelTank);
    }

    public bool EngineIsRunning => _engine.IsRunning;
    
    public void EngineStart()
    {
        _engine.Start();
    }

    public void EngineStop()
    {
        _engine.Stop();
    }

    public void Refuel(double liters)
    {
        _fuelTank.Refuel(liters);
    }

    public void RunningIdle()
    {
        _engine.Consume(0.0003);
    }
}