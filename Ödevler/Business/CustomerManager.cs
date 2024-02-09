using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ödevler.Entities;

namespace Ödevler.Business
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " eklendi");
        }
        public void GetAll() //Listeleme 
        {
            Console.WriteLine("Listeledim kardeş");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Name + " bilgileri güncellendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " aramızdan ayrıldı..");
        }
    }
}
