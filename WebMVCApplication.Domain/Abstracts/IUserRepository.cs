using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVCApplication.Domain.Entities;

namespace WebMVCApplication.Domain.Abstracts
{
    public interface IUserRepository
    {
        IEnumerable<User> Items { get; }
        void Signin(User value);
        void Signup(User value);
    }
}
