using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Models;

namespace WebApplicationTest.Repository
{
    public class WelcomeRepository : IWelcomeRepository
    {
        public List<string> GetWelcomeModelRepository()
        {
            var data = new List<string>();
            data.Add("Sabbir Hasan");
            data.Add("3/3/2019");
            return data;
        }
    }
}
