namespace Singleton {

    public sealed class MySqlConnection
    {
        const string MYSQL_PREFIX = "mysql://";
        private string host;
        private int port;
        
        private string user; 
        
        private string password;
        
        private string db;

        private bool opened;

        private bool locked;

        private MySqlConnection(string host, int port, string user, string password, string db)
        {
            this.host = host;
            this.port = port;
            this.user = user;
            this.password = password;
            this.db = db;
        }

        string url() {
            return MYSQL_PREFIX + 
                "//" + 
                this.user +
                ":" +
                this.password +
                "@" +
                this.host +
                ":" + 
                this.port +
                "/" + 
                this.db;
        }

        public Dictionary<string, Object> runQuery(string query) {
            if (!opened) throw new Exception("Db is closed");

            locked = true;

            Console.WriteLine("running query to " + url());

            var result = new Dictionary<string, Object>(){
                {"a", "true"},
                {"b", "false"}
            };

            locked = false;

            return result;
        }

        public void open() {
            opened = true;
        }

        public void close() {
            opened = false;
        }

        static private MySqlConnection? instance;

        public static MySqlConnection GetInstance(string host, int port, string user, string password, string db) { 
            return MySqlConnection.instance != null 
                ? MySqlConnection.instance
                : MySqlConnection.instance = new MySqlConnection(host, port, user, password, db); 
        }
    }
}