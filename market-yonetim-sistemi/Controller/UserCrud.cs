using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Controller
{
    public class UserCrud : ICrud<User>
    {
        DataContext db = new DataContext();

        public bool Add(User entity)
        {
            if (entity != null
                && !String.IsNullOrWhiteSpace(entity.Name)
                && !String.IsNullOrWhiteSpace(entity.Surname)
                && !String.IsNullOrWhiteSpace(entity.Email)
                && !String.IsNullOrWhiteSpace(entity.Password)
                && !String.IsNullOrWhiteSpace(entity.Description)
                && !String.IsNullOrWhiteSpace(entity.Password)
                )
            {
                db.User.Add(entity);
                db.SaveChanges();
                return true;
            };
            return false;
        }

        public bool Delete(int id)
        {
            var item = db.User.Find(id);
            if (item != null)
            {
                item.IsDelete = true;
                db.SaveChanges();

                return true;

            }
            return false;
        }

        public List<User> GetAll()
        {
            return db.User.Where(x => x.IsDelete == false).ToList();
        }

        public User GetById(int id)
        {
            var item = db.User.Find(id);

            if (item != null)
            {
                return item;
            }
            return null;
        }

        public bool Update(User entity, int id)
        {
            var item = GetById(id);

            if (item != null)
            {

                item.Name = entity.Name;
                item.Surname = entity.Surname;
                item.Email = entity.Email;
                item.Password = entity.Password;
                item.RoleId = entity.RoleId;
                item.IsStatus = entity.IsStatus;
                item.Description = entity.Description;
                item.Image = entity.Image;
                db.SaveChanges();

                return true;
            }
            return false;
        }
    }
}
