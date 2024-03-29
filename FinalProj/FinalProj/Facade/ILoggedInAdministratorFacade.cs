﻿using FinalProj.Login;
using FinalProj.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj.Facade
{
    public interface ILoggedInAdministratorFacade
    {
        void CreateNewAirline(LoginToken<Administrator> token, AirlineCompany airline);
        void UpdateAirlineDetails(LoginToken<Administrator> token, AirlineCompany customer);
        void RemoveAirline(LoginToken<Administrator> token, AirlineCompany airline);
        void CreateNewCustomer(LoginToken<Administrator> token, Customer customer);
        void UpdateCustomerDetails(LoginToken<Administrator> token, Customer customer);
        void RemoveCustomer(LoginToken<Administrator> token, Customer customer);

    }
}
