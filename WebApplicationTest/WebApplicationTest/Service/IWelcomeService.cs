using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Models;
namespace WebApplicationTest.Service
{
    public interface IWelcomeService
    {
        WelcomeModel GetWelcomeModelService();
    }
}
