using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Factories;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using Domain;

namespace BLL.Service
{
    public class UserInContractService
    {
        private IUsersInContractRepository _repo;
        private UserInContractFactory _factory;

        public UserInContractService()
        {
            this._repo = new UsersInContractRepository(new ApplicationDbContext());
            this._factory = new UserInContractFactory();
        }

        public List<UserInContractDTO> GetUserInContractDtos()
        {
            return this._repo.All.Select(x => _factory.createFullUserInContractDTO(x)).ToList();
        }

        public List<UserInContractDTO> GetUserInContractsByUserId(string id)
        {
            var res = this._repo.All.Where(x => x.UserId == id).ToList();
            List < UserInContractDTO> list = res.Select(usr => _factory.createFullUserInContractDTO(usr)).ToList();
            return list;
        }

        public UserInContractDTO GetUserInContractDTO(string userId, int appliesToOfferId)
        {
            return _factory.createFullUserInContractDTO(_repo.GetByTwoId(userId, appliesToOfferId));
        }

        public bool Update(UsersInContract contract)
        {
            _repo.Update(contract);
            _repo.SaveChanges();
            return true;
        }

        public UsersInContract Create(UsersInContract cont)
        {
            _repo.Add(cont);
            _repo.SaveChanges();

            return cont;
        }

        public bool Delete(int id)
        {
            var quer = _repo.GetById(id);
            if (quer == null)
            {
                return false;
            }
            _repo.Delete(id);
            _repo.SaveChanges();

            return true;

        }
    }
}
