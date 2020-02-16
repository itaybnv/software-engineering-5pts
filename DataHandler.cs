using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop
{
    abstract class DataHandler<T> where T : class
    {
        protected dbEntities db = new dbEntities();

        public virtual List<T> GetData()
        {
            return db.Set<T>().ToList();
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

        public virtual void AddData(T item)
        {
            // If item is verified, add to database
            if (VerifyItem(item))
            {
                // Add item to database
                db.Set<T>().ToList().Add(item);

                // Save the database
                db.SaveChanges();
            }

        }

        protected abstract bool VerifyItem(T item);
    }
}
