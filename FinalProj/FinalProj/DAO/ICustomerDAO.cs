using FinalProj.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj.DAO
{
    public interface ICustomerDAO : IBasicDB<Customer>
    {
        Customer GetCustomerByUserame(string name);
    }
}
