﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProj.Login;
using FinalProj.POCO;

namespace FinalProj.Facade
{
    public class LoggedInAdministratorFacade : AnonymousUserFacade, ILoggedInAdministratorFacade
    {
        public void CreateNewAirline(LoginToken<Administrator> token, AirlineCompany airline)
        {
            throw new NotImplementedException();
        }

        public void CreateNewCustomer(LoginToken<Administrator> token, Customer customer)
        {
            throw new NotImplementedException();
        }

        public void RemoveAirline(LoginToken<Administrator> token, AirlineCompany airline)
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(LoginToken<Administrator> token, Customer customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateAirlineDetails(LoginToken<Administrator> token, AirlineCompany customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerDetails(LoginToken<Administrator> token, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
