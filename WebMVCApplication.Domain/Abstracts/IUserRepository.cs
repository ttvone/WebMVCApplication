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
        object Signup(User value);
    }
}
