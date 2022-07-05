// See https://aka.ms/new-console-template for more information
namespace Singleton {

    class Program {
        public static void Main(string[] args)
        {
            var conn = MySqlConnection.GetInstance("localhost", 3306, "root", "root", "mydb");
            conn.open();
            System.Console.WriteLine(conn.runQuery("select * from users;"));
        }
    }

}