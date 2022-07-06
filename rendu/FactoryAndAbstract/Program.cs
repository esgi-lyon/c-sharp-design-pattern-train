namespace AutomobileWithBluetoothSystem
{

    class Program {
        public static void Main(string[] args)
        {
            var mercedesAmg = AutomobileFactoryMethod
                .create(
                    "amg",
                    100D,
                    "#3386FF",
                    "",
                    new SportCarBluetoothFactory()
                );

            Console.WriteLine(mercedesAmg);

            var prius = AutomobileFactoryMethod
                .create(
                    "prius",
                    10D,
                    "#83AAE3",
                    "",
                    new ElectricCarBluetoothFactory()
                );

            Console.WriteLine(prius);
        }
    }
}
