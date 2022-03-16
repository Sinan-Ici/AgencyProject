using Business.Abstract;
using DataAccess.Context;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        AgencyProjectContext db = new AgencyProjectContext();
        public void AddAgency(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void AddCustomer(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void DeleteAgency(User user)
        {
            var deletedAgency = db.Entry(user);
            deletedAgency.State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void DeleteCustomer(User user)
        {
            var deletedAgency = db.Entry(user);
            deletedAgency.State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<User> GetAll()
        {
            var list= db.Users.ToList();
            return (list);

        }

        public virtual User GetByName(string name)
        {
            return db.Set<User>().SingleOrDefault(x => x.UserName == name);
        }

        public User GetByPassword(string password)
        {
            return db.Set<User>().SingleOrDefault(x => x.Password == password);
        }
    }
}
