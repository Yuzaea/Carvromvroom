using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Carvromvroom
{
    public class VROOOMRepo
    {



        private List<Car> carsgovroom = new List<Car>();


        public IEnumerable<Car> GetAll()
        {
            return carsgovroom;
        }




        public Car GetBookByID(int id)
        {
            foreach (var book in carsgovroom)
            {
                if (book.Id == id) return book;
            }
            return null;
        }



        public Car Add(Car book)
        {
            if (book == null)
            {
                throw new ArgumentNullException();
            }
            int newID = carsgovroom.Count > 0 ? carsgovroom.Max(b => b.Id) + 1 : 1;
            book.Id = newID;

            carsgovroom.Add(book);

            return book;
        }


        public bool Delete(int id)
        {
            Car bookToDelete = null;
            foreach (var book in carsgovroom)
            {
                if (book.Id == id)
                {
                    bookToDelete = book;
                    break; 
                }
            } if (bookToDelete != null)
            {
                carsgovroom.Remove(bookToDelete);return true; 
            }
            else
            { return false;
            }
        }



        public bool Update(int id, Car UpdateBookie)
        {
            var carToUpdate = carsgovroom.FirstOrDefault(car => car.Id == id);
            if (carToUpdate != null)
            {
                carToUpdate.Model = UpdateBookie.Model;
                carToUpdate.Price = UpdateBookie.Price;
                carToUpdate.LicensePlate = UpdateBookie.LicensePlate;
                return true;
            }
            return false;
        }
    }

}
