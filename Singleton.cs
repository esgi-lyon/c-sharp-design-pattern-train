class DbConnect
{
    protected string host;
    protected int port;
    
    protected string user; 
    
    protected string password;
    
    protected string db;

    private DbConnect(string host, int port, string user, string password, string db)
    {
        this.host = host;
        this.port = port;
        this.user = user;
        this.password = password;
        this.db = db;
    }

    static private DbConnect? instance;

    static private DbConnect getInstance(string host, int port, string user, string password, string db) { 
        return DbConnect.instance != null 
            ? DbConnect.instance
            : DbConnect.instance = new DbConnect(host, port, user, password, db); 
    }
}