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
    public class CategoryCrud : ICrud<Category>
    {
        DataContext db = new DataContext();
        public bool Add(Category entity)
        {
            if (entity != null
               && !String.IsNullOrWhiteSpace(entity.Name)
               && !String.IsNullOrWhiteSpace(entity.Description)
               )
            {
                db.Category.Add(entity);
                db.SaveChanges();
                return true;
            };
            return false;
        }

        public bool Delete(int id)
        {
            var item = db.Category.Find(id);
            if (item != null)
            {
                item.IsDelete = true;
                db.SaveChanges();

                return true;
            }
            return false;
        }

        public List<Category> GetAll()
        {
            return db.Category.Where(x => x.IsDelete == false).ToList();
        }

        public Category GetById(int id)
        {
           var item = db.Category.Find(id);

            if (item !=null)
            {
                return item;
            }
            return null;
        }

        public bool Update(Category entity, int id)
        {
            var item = db.Category.Find(id);

            if (item != null)
            {
                item.Description = entity.Description;
                item.Image = entity.Image;
                item.IsStatus = entity.IsStatus;
                item.Name = entity.Name;
                item.ProductList = entity.ProductList;
                db.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
