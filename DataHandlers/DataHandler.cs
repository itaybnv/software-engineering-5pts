using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop
{
    abstract class DataHandler<T> where T : class
    {
        static protected dbEntities db = new dbEntities();

        public virtual List<T> GetData(bool hideDeleted)
        {
            if (hideDeleted)
            {
                return db.Set<T>().ToList().FindAll(o => !(bool)(typeof(T).GetProperty("deleted").GetValue(o)));
            }
            else
            {
                return db.Set<T>().ToList();
            }
        }

        public virtual void RemoveData(T item)
        {
            // Set the data item as deleted
            typeof(T).GetProperty("deleted").SetValue(item, true);

            // Notify db that the item was changed
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;

            // Save the database
            db.SaveChanges();
        }

        public virtual void AddOrUpdate(T item)
        {
            try
            {
                VerifyItem(item);

                // Add item to database
                db.Set<T>().AddOrUpdate(item);

                // Save the database
                db.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public dbEntities GetEntities()
        {
            return db;
        }

        protected abstract void VerifyItem(T item);
    }
}
