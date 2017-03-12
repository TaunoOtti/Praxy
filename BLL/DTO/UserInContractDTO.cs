using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace BLL.DTO
{
    public class UserInContractDTO
    {
        public int UsersInContractId { get; set; }
        public DateTime ContractStartTime { get; set; }
        public DateTime ContractEndTime { get; set; }
        public string AdditionalDetails { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int AppliesToOfferId { get; set; }
        public virtual AppliesToOffer AppliesToOffer { get; set; }
    }
}
