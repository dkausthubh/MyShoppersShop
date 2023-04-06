using MyOnlineShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOnlineShop.Repository
{
    public class GenericUnitOfWork:IDisposable
    {
        private Ecommerce_dbEntities DbEntity = new Ecommerce_dbEntities();
        public IRepository<Tbl_EntityType> GetRepositoryInstance<Tbl_EntityType>() where Tbl_EntityType: class
        {
            return new GenericRepository<Tbl_EntityType>(DbEntity);
        }

        public void SaveChanges()
        {
            DbEntity.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    DbEntity.Dispose();
                }
            }
            this.disposed = true;
           
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
    }
}