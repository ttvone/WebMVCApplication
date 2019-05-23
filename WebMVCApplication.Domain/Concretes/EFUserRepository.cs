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

        public object Signup(User value)
        {
            value.UserPassword = security.PasswordHash(value.UserPassword);
            value.UserCreated = DateTime.Now;
            value.UserUpdated = DateTime.Now;
            return value;
        }
    }
}
