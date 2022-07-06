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


        public string url() {
            return host + ":" + port;
        }
    }


    abstract class AbstractNetworkConfigurationBuilder
    {
        protected int? port { get; set; }

        public abstract AbstractNetworkConfigurationBuilder configureHost(string host);

        public abstract NetworkConfiguration build();

        /// Configure ssh port
        /// should has default in concrete builder
        // need to be called from build method
        public abstract AbstractNetworkConfigurationBuilder configurePort(int? port);
    }

    class HttpConfigurationBuilder : AbstractNetworkConfigurationBuilder
    {
        
        const int DefaultHttpPort = 80;
        string? host;


        public override HttpConfigurationBuilder configureHost(string host)
        {
            if (!host.Contains("http")) throw new Exception("Not a valid host" + host);

            this.host = host;

            return this;
        }

        public override HttpConfigurationBuilder configurePort(int? port) {
            this.port = port ?? DefaultHttpPort;

            return this;
        }

        public override NetworkConfiguration build()
        {
            return new NetworkConfiguration(this.host!, this.port ?? DefaultHttpPort);
        }
    }

    class SshConfigurationBuilder : AbstractNetworkConfigurationBuilder
    {
        const int DefaultSshPort = 22;
        
        string? host;


        public override SshConfigurationBuilder configureHost(string host)
        {
            if (!host.Contains("ssh")) throw new Exception("Not a valid host" + host);

            this.host = host;

            return this;
        }

        public override SshConfigurationBuilder configurePort(int? port) {
            this.port = port ?? DefaultSshPort;

            return this;
        }

        public override NetworkConfiguration build()
        {
            return new NetworkConfiguration(this.host!, this.port ?? DefaultSshPort);
        }
    }
}