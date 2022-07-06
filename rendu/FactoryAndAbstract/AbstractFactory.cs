
namespace AbstractFactory {

    public interface IAutomobileSpecFactory
    {
        IBluetooth createBluetoothSystem();
    }

    public interface IBluetooth
    {
        string Name { get; }
        // Could imagine properties of bluetooth
    }

    class V4Bluetooth : IBluetooth
    {
        public string Name { get; } = "v4Bluetooth";
        // Could imagine properties of bluetooth
    }

    class V3Bluetooth : IBluetooth
    {
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

        public override string? ToString() {
            return "{" + 
                this.model + 
                this.color + 
                this.space + 
                this.power + 
                this.bluetoothSystem.Name + 
            "}";
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

    // factory method using abstract factory
    public class AutomobileFactory
    {
        public Automobile create(string model, double power, string color, string space, IAutomobileSpecFactory bluetoothFactory)
        {
            return new Automobile(model, color, space, power, bluetoothFactory.createBluetoothSystem());
        }
    }
}