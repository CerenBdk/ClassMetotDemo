using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer 
            { 
                CustomerID = 1, 
                FirstName = "Harry", 
                LastName = "Potter", 
                PhoneNumber = "1212121212", 
                Address = "The Cupboard under the Stairs, + PRivet Drive, Little Whinging SURREY",
                Balance = "£ 10.000"
            };

            Customer c2 = new Customer
            {
                CustomerID = 2,
                FirstName = "Hermione",
                LastName = "Granger",
                PhoneNumber = "2323232323",
                Address = "Hampstead, London.",
                Balance = "£ 15.070"
            };

            Customer c3 = new Customer
            {
                CustomerID = 3,
                FirstName = "Ron",
                LastName = "Weasley",
                PhoneNumber = "3434343434",
                Address = "Ottery St. Catchpole, Devon.",
                Balance = "£ 8.930"
            };

            Customer c4 = new Customer
            {
                CustomerID = 4,
                FirstName = "Sirius",
                LastName = "Black",
                PhoneNumber = "4545454545",
                Address = "12 Grimmauld Place, London.",
                Balance = "£ 11.642"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCutomer(c1);
            customerManager.AddCutomer(c2);
            customerManager.AddCutomer(c3);
            customerManager.AddCutomer(c4);

            customerManager.GetCustomerList();
            customerManager.GetCustomer(c1);
            customerManager.DeleteCustomer(c3);
            
            Console.ReadLine();
        }
    }
}
