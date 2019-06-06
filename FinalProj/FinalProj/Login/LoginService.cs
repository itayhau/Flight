using FinalProj.DAO;
using FinalProj.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj.Login
{
    public class LoginService : ILoginService
    {
        private IAirlineDAO _arilineDAO;

        public bool TryAdminLogin(string userName, string password, out LoginToken<Administrator> token)
        {
            throw new NotImplementedException();
        }

        public bool TryArilineLogin(string userName, string password, out LoginToken<AirlineCompany> token)
        {
            throw new NotImplementedException();
        }

        public bool TryCustomerLogin(string userName, string password, out LoginToken<Customer> token)
        {
            throw new NotImplementedException();
        }
    }
}
