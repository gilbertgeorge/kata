namespace codewars.kyu5.Car.Interfaces;

public interface IEngine
{
    bool IsRunning { get; }

    void Consume(double liters);

    void Start();

    void Stop();
}