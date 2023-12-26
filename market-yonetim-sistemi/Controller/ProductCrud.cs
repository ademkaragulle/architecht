using MarketYönetimSistemi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.Interface
{
    public class ProductCrud : ICrud<Product>
    {
        DataContext db = new DataContext();
        public bool Add(Product entity)
        {
            if (entity != null
                && !String.IsNullOrWhiteSpace(entity.Name)
                && !double.IsPositiveInfinity(entity.Price)
                && !String.IsNullOrWhiteSpace(entity.Description)
                )
            {
                db.Product.Add(entity);
                db.SaveChanges();
                return true;
            };
            return false;
        }

        public bool Delete(int id)
        {
            var item = db.Product.Find(id);
            if (item != null)
            {
                item.IsDelete = true;
                db.SaveChanges();

                return true;

            }
            return false;
        }

        public List<Product> GetAll()
        {
            return db.Product.Where(x => x.IsDelete == false).ToList();
        }

        public Product GetById(int id)
        {
            var item = db.Product.Find(id);

            if (item != null)
            {
                return item;
            }
            return null;
        }

        public bool Update(Product entity, int id)
        {
            var item = db.Product.Find(id);

            if (item != null)
            {

                item.Name = entity.Name;
                item.Price = entity.Price;
                item.Stock = entity.Stock;
                item.Description = entity.Description;
                item.CategoryId = entity.CategoryId;
                item.IsStatus = entity.IsStatus;
                item.Image = entity.Image;
                db.SaveChanges();

                return true;
            }

            return false;
        }
    }
}

