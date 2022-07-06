// See https://aka.ms/new-console-template for more information
namespace NetworkBuilders
{

    class BuilderProcess
    {
        public static void Main(string[] args)
        {
            var ssgSimpleConfig = new SshConfigurationBuilder()
                .configureHost("ssh://localhost")
                .build();

            System.Console.WriteLine(ssgSimpleConfig.url());


            var httpSimpleConfig = new HttpConfigurationBuilder()
                .configureHost("http://localhost")
                .build();

            System.Console.WriteLine(httpSimpleConfig.url());
        }
    }
}
