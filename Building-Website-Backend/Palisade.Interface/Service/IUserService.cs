using Palisade.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Palisade.Service
{
    public interface IUserService
    {
        UserDTO Login(UserDTO userDto);
        UserDTO Register(UserDTO userDto);
    }
}
