using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using Domain;

namespace BLL.Factories
{
    public class UserInContractFactory
    {
        public UserInContractDTO createFullUserInContractDTO(UsersInContract uic)
        {
            return new UserInContractDTO
            {
                UsersInContractId = uic.UsersInContractId,
                AdditionalDetails = uic.AdditionalDetails,
                AppliesToOfferId = uic.AppliesToOfferId,
                AppliesToOffer = uic.AppliesToOffer,
                ContractEndTime = uic.ContractEndTime,
                ContractStartTime = uic.ContractStartTime,
                UserId = uic.UserId,
                User = uic.User
            };
        }
    }
}
