﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj.Login
{
    public class LoginToken<T> where T : IUser
    {
        public T User { get; set; }
    }
}
