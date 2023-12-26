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
    internal class SellCrud : ICrud<SellProduct>
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
            throw new NotImplementedException();
        }

        public List<SellProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public SellProduct GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(SellProduct entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
