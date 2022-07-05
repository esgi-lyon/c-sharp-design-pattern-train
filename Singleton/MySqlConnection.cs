namespace Singleton {

    public sealed class MySqlConnection
    {
        const string MYSQL_PREFIX = "mysql://";
        protected string host;
        protected int port;
        
        protected string user; 
        
        protected string password;
        
        protected string db;

        private bool opened;

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

            return new Dictionary<string, Object>(){
                {"a", "true"},
                {"b", "false"}
            };
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