using Ödevler.Business;
using Ödevler.Entities;

Customer customer1 = new Customer();
customer1.Name = "Ekrem";
customer1.Surname = "Paşa";
customer1.Address = "Texas";


Customer customer2 = new Customer();
customer2.Name = "Sude";
customer2.Surname = "Paşaoğlu";
customer2.Address = "Zalım turkey";

CustomerManager customerManager = new CustomerManager();
//instance - ödev
customerManager.Add(customer1);
customerManager.Update(customer1);
customerManager.GetAll();
customerManager.Delete(customer1);


