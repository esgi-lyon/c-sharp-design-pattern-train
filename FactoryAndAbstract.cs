
public interface IAutomobileSpecFactory
{
    IBluetooth createBluetoothSystem();
}

public interface IBluetooth
{
    string Name { get; }
}

class V4Bluetooth: IBluetooth {
    public string Name { get; } = "v4Bluetooth";
}

class V3Bluetooth: IBluetooth {
    public string Name { get; } = "v3Bluetooth";
}

public class Automobile
{
    protected string model;
    protected string color;
    protected string space;
    protected double power;
    protected IBluetooth bluetoothSystem;

    public Automobile(
     string model,
      string color,
      string space,
      double power,
      IBluetooth bluetoothSystem
    ) {
        this.model = model;
        this.color = color;
        this.space = space;
        this.power = power;
        this.bluetoothSystem = bluetoothSystem;
    }
}


class ElectricCarBluetoothFactory : IAutomobileSpecFactory
{
    public IBluetooth createBluetoothSystem()
    {
        return new V3Bluetooth();
    }
}

class SportCarBluetoothFactory : IAutomobileSpecFactory
{

    public IBluetooth createBluetoothSystem()
    {
        return new V4Bluetooth();
    }
}


class AutomobileFactory
{
    public Automobile create(string model, double power, string color, string space, IAutomobileSpecFactory bluetoothFactory) {
        return new Automobile(model, color, space, power, bluetoothFactory.createBluetoothSystem());
    }
}
