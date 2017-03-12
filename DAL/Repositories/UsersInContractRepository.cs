using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Domain;

namespace DAL.Repositories
{
    public class UsersInContractRepository : EFRepository<UsersInContract>, IUsersInContractRepository  
    {
        public UsersInContractRepository(IDbContext dbContext) : base(dbContext)
        {
        }

        public UsersInContract GetByTwoId(string usrId, int apliesId)
        {
            return DbSet.FirstOrDefault(x => x.UserId == usrId && x.AppliesToOfferId == apliesId);
        }
    }
}
