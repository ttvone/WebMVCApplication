using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVCApplication.Domain.Abstracts;
using WebMVCApplication.Domain.Entities;
using WebMVCApplication.Domain.Infrastructures;

namespace WebMVCApplication.Domain.Concretes
{
    public class EFUserRepository : IUserRepository
    {
        private readonly EFDbContextRepository contextRepo;
        private readonly Security security;
        public EFUserRepository()
        {
            contextRepo = new EFDbContextRepository();
            security = new Security();
        }

        public IEnumerable<User> Items => contextRepo.Users;

        public void Signin(User value)
        {
            var userModel = Items.SingleOrDefault(m => m.UserEmail.Equals(value.UserEmail));
            if (userModel == null)
                throw new Exception("Email is invalid");
            if (!security.PasswordVerify(userModel.UserPassword, value.UserPassword))
                throw new Exception("Password is invalid");
            value.UserCreated = userModel.UserCreated;
            value.UserUpdated = userModel.UserUpdated;
            value.UserRole = userModel.UserRole;
            value.UserId = userModel.UserId;
        }

        public void Signup(User value)
        {
            value.UserPassword = security.PasswordHash(value.UserPassword);
            value.UserCreated = DateTime.Now;
            value.UserUpdated = DateTime.Now;
            value.UserRole = UserRole.Member;
            if (Items.Where(m => m.UserEmail.Equals(value.UserEmail)).Count() > 0)
                throw new Exception("Is Already email");
            contextRepo.Users.Add(value);
            contextRepo.SaveChanges();
        }
    }
}
