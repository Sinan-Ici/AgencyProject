using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        void AddCustomer(User user);
        void DeleteCustomer(User user);
        void AddAgency(User user);
        void DeleteAgency(User user);
        List<User>GetAll();
        User GetByName(string name);
        User GetByPassword(string password);
    }
}
