using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using Domain;

namespace BLL.Factories
{
    public class UserFactory
    {
        public UserDTO createBasicDTO(User user)
        {
            return new UserDTO
            {
                UserId = user.Id,
                Email = user.Email
            };
        }
    }
}
