using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        string  CreateToken(AppUser user);
    }
}