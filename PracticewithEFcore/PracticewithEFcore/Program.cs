using System;
using PracticewithEFcore.DBContext;

namespace PracticewithEFcore
{
    class Program
    {
        static void Main(string[] args)
        {
            const string _connectionString = "Server = DESKTOP-28DHLU6; Database = EFcore; User Id = arafat; Password = 123; ";
            var context = new ShoppingContext(_connectionString);

        }
    }
}
