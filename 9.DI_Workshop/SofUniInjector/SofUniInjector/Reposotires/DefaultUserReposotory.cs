using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Reposotires
{
    public class DefaultUserReposotory : IUserReposotory
    {
        private readonly IPaymentReposotory _paymentRepo;
        private readonly ISoftUniReposotory _softUniRepo;

        public DefaultUserReposotory(IPaymentReposotory paymentRepo,ISoftUniReposotory softUniRepo)
        {
            this._paymentRepo = paymentRepo;
            this._softUniRepo = softUniRepo;
        }
        public void Print()
        {
            Console.WriteLine("User repo called!");
            Console.WriteLine("User repo Calling payments pay!");
            this._paymentRepo.Pay();
            Console.WriteLine("User repo Calling also sofUni repo");
            this._softUniRepo.Oop();
        }
    }
}
