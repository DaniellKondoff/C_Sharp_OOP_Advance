using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Reposotires
{
    public class DefaultSoftUniReposotory : ISoftUniReposotory
    {
        private readonly IPaymentReposotory _paymentRepo;

        public DefaultSoftUniReposotory(IPaymentReposotory paymentRepo)
        {
            this._paymentRepo = paymentRepo;
        }
        public void Oop()
        {
            Console.WriteLine("softuni repo called");
            Console.WriteLine("softuni repo tries to call payments repo");
            this._paymentRepo.Pay();
        }
    }
}
