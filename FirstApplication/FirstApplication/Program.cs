using System;
using System.Data.SqlClient;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            const string conn = "Server = DESKTOP-28DHLU6; Database = test; User Id = arafat; Password = 123; ";

            using (var connection = new SqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    var sql = "Insert into Login ([Name],Email,Contact,[Address],Username,[Password],[Type]) Values ('A','a@gmail.com','123','mirpur','arafat','1234','user');";
                    using (var command = new SqlCommand(sql , connection))
                    {
                        
                        int a = command.ExecuteNonQuery();
                        if(a==1)
                        {
                            Console.WriteLine("Data Inserted");
                        }
                       
                       

                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    Console.WriteLine("Data Not Inserted");
                }
                finally
                {
                    connection?.Close();
                }
            }
        }
    }
}
