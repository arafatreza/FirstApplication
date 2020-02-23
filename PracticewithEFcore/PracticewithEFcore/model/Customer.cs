using System;
using System.Collections.Generic;
using System.Text;

namespace PracticewithEFcore.model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime RegisterDate { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordNew { get; set; }
    }
}
