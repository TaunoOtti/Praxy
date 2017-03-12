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
    public class UserService
    {
        private IEFRepository<User> _repo;
        private  UserFactory _factory;

        public UserService()
        {
            this._repo = new UserRepository(new ApplicationDbContext());
            this._factory = new UserFactory();
        }

        public List<UserDTO> getAllPersons()
        {
            return this._repo.All.Select(x => _factory.createBasicDTO(x)).ToList();
        }

        public List<User> getAllFullPersons()
        {
            return this._repo.All;
        }

        public UserDTO getUserByEmail(string email)
        {
            var usr =  this._repo.All.FirstOrDefault(x => x.UserName == email);
            return _factory.createBasicDTO(usr);
        }

        public UserDTO getUserById(string id)
        {
            var usr = this._repo.All.FirstOrDefault(x => x.Id == id);
            return _factory.createBasicDTO(usr);
        }
    }
}
