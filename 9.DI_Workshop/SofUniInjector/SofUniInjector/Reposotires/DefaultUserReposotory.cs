using SofUniInjector.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Reposotires
{
    [InjectionCandidate]
    public class DefaultUserReposotory : IUserReposotory, INeshtoSIInterface
    {
        private readonly IPaymentReposotory _paymentRepo;
        private readonly ISoftUniReposotory _softUniRepo;
        private int count;
        public DefaultUserReposotory(IPaymentReposotory paymentRepo,int count,ISoftUniReposotory softUniRepo)
        {
            this._paymentRepo = paymentRepo;
            this._softUniRepo = softUniRepo;
            this.count = count;
        }
        public void Print()
        {
            Console.WriteLine($"My count is {this.count++}" );
            Console.WriteLine("User repo called!");
            Console.WriteLine("User repo Calling payments pay!");
            this._paymentRepo.Pay();
            Console.WriteLine("User repo Calling also sofUni repo");
            this._softUniRepo.Oop();
        }
    }
}
