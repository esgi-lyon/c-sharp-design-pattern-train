namespace NetworkBuilders
{

    class NetworkConfiguration
    {
        string host;

        int port;

        public NetworkConfiguration(string host, int port)
        {
            this.host = host;
            this.port = port;
        }
    }


    abstract class AbstractNetworkConfigurationBuilder
    {
        protected int port { get; set; }

        public abstract AbstractNetworkConfigurationBuilder configureHost(string host);

        AbstractNetworkConfigurationBuilder configurePort(int port)
        {
            this.port = port;

            return this;
        }
    }

    class HttpConfigurationBuilder : AbstractNetworkConfigurationBuilder
    {
        string? host;


        public override HttpConfigurationBuilder configureHost(string host)
        {
            if (!host.Contains("http")) throw new Exception("Not a valid host" + host);

            this.host = host;

            return this;
        }

        NetworkConfiguration build()
        {
            return new NetworkConfiguration(this.host!, this.port);
        }
    }

    class SshConfigurationBuilder : AbstractNetworkConfigurationBuilder
    {
        string? host;


        public override SshConfigurationBuilder configureHost(string host)
        {
            if (!host.Contains("ssh")) throw new Exception("Not a valid host" + host);

            this.host = host;

            return this;
        }

        NetworkConfiguration build()
        {
            return new NetworkConfiguration(this.host!, this.port);
        }
    }

}