using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Models;
using WebApplicationTest.Repository;

namespace WebApplicationTest.Service
{
    public class WelcomeService: IWelcomeService
    {

        private readonly IWelcomeRepository _welcomeRepository;

        public WelcomeService(IWelcomeRepository welcomeRepository)
        {
            _welcomeRepository = welcomeRepository;
        }
        public WelcomeModel GetWelcomeModelService()
        {

            var model = new WelcomeModel();
            var data = new WelcomeRepository().GetWelcomeModelRepository();
            model.Name = data[0];
            model.DateTime = DateTime.Parse(data[1]);
            return model;
        }
    }
}
