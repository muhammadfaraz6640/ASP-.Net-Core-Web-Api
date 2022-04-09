using PractiseWebApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractiseWebApiProject.Interfaces
{
    public interface IJWTManager
    {
        Tokens Authenticate(User users);
    }
}
