using SofUniInjector.Reposotires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Services
{
    public class UserService : IUserService
    {
        private readonly INeshtoSIInterface _userrepo;
        private readonly ISoftUniReposotory _softUnirepo;

        public UserService(INeshtoSIInterface userrepo, ISoftUniReposotory softUnirepo)
        {
            this._userrepo = userrepo;
            this._softUnirepo = softUnirepo;     
        }
        public void Rename()
        {
            Console.WriteLine("User service called");
            Console.WriteLine("service calls user repo");
            this._userrepo.Print();
            Console.WriteLine("User also called softuni repo");
            this._softUnirepo.Oop();
        }
    }
}
