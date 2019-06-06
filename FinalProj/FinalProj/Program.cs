using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new UserNotFoundException();
            throw new WrongPasswordException();
        }
    }
}
