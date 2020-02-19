using System;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            const string conn = "Server = ; Database = ; User Id = ; Password = ; ";

            using (var connection = new SqlConnect(conn))
            {
                try
                {
                    connection.Open();
                    var sql = "sql command";
                    using (var command = new SqlCommand(sql , connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection?.Close();
                }
            }
        }
    }
}
