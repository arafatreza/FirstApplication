using System;
using System.Collections.Generic;
using PracticewithEFcore.DBContext;
using PracticewithEFcore.model;

namespace PracticewithEFcore
{
    class Program
    {
        static void Main(string[] args)
        {

            const string _connectionString = "Server = DESKTOP-28DHLU6; Database = test; User Id = arafat; Password = 123; ";
            var context = new ShoppingContext(_connectionString);
            var Customer = new Customer()
            {
           
                Name = "A",
                Email = "a@gmail.com",
                Mobile = "01625420852",
                RegisterDate = DateTime.Now,
                UserName = "Arafat",
                Password = "123",
                PasswordNew = "1234"
        };
            context.Customers.Add(Customer);
             
            context.SaveChanges();
            




        }
    }
}
