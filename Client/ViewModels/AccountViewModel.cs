using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Models;
using Client.Services;

namespace Client.ViewModels
{
    public class AccountViewModel
    {
        private AccountService _service;

        public AccountViewModel()
        {
            _service = new AccountService();
        }

        public void Login(string email, string password)
        {
            _service.Login(new User.LoginBindingModel
            {
                grant_type = "password",
                Password = password,
                Username = email
            });
        }

        public void Register(string email, string password1, string password2)
        {
            _service.Register(new User.RegisterBindingModel
            {   
                Password = password1,
                ConfirmPassword = password2,
                Email = email
            });
        }


    }
}
