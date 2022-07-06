// See https://aka.ms/new-console-template for more information
namespace AbstractFactory
{

    class Program {
        public static void Main(string[] args)
        {
            var mercedesAmg = new AutomobileFactory()
                .create(
                    "amg",
                    100D,
                    "#3386FF",
                    "",
                    new SportCarBluetoothFactory()
                );

            Console.WriteLine(mercedesAmg);
        }
    }
}
