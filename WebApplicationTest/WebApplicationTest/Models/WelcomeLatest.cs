using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Models;
using WebApplicationTest.Repository;
using WebApplicationTest.Service;

namespace WebApplicationTest.Models
{
    public class WelcomeLatest : IWelcomeService
    {
     
        public WelcomeModel GetWelcomeModelService()
        {
            var model = new WelcomeModel();
            model.Name = "Arafat";
            model.DateTime = DateTime.Now;
            return model;
        }
    }
}
