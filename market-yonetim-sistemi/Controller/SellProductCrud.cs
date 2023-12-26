using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Data;

namespace MarketYönetimSistemi.Controller
{
    internal class SellProductCrud : ICrud<SellProduct>
    {
        DataContext db = new DataContext(); 
        public bool Add(SellProduct entity)
        {
            if (entity != null)
            {
                db.SellProduct.Add(entity);
                db.SaveChanges();

                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var item = db.SellProduct.Find(id);
            if (item != null)
            {
                item.IsDelete = true;
                db.SaveChanges();

                return true;

            }
            return false;
        }

        public List<SellProduct> GetAll()
        {
            return db.SellProduct.Where(x => x.IsDelete != true).ToList();
        }

        public SellProduct GetById(int id)
        {
            var item = db.SellProduct.Find(id);

            if (item != null)
            {
                return item;
            }
            return null;
        }

        public bool Update(SellProduct entity, int id)
        {
            var item = db.SellProduct.Find(id);

            if (item != null)
            {
                item.OrderId = entity.OrderId;
                item.ProductId = entity.ProductId;  
                item.Quantity = entity.Quantity;
                item.Price = entity.Price;
                item.TotalPrice = entity.Price * entity.Quantity;
                db.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
