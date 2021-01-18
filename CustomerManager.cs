using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> cList = new List<Customer> { };

        public void GetCustomerList()
        {
            Console.WriteLine("\nList of all registered customers: ");
            int count = 1;
            foreach (var c in cList)
            {
                Console.WriteLine(count +"-"+ c.FirstName + c.LastName);
                count++;
            }
            Console.WriteLine();
        }

        public void GetCustomer(Customer c)
        {
            Console.WriteLine("Information of customer ID {0}: ", c.CustomerID);
            Console.WriteLine("- First Name: {1} \n- Last Name: {2} \n- Phone Number: {3} \n- Address: {4} \n- Balance: {5} \n ", 
                c.CustomerID, 
                c.FirstName,
                c.LastName,
                c.PhoneNumber,
                c.Address,
                c.Balance);
        }

        public void AddCutomer(Customer c)
        {
            cList.Add(c);
            Console.WriteLine("{0} {1} has been added.", c.FirstName, c.LastName);
        }

        public void DeleteCustomer(Customer c)
        {
            cList.Remove(c);
            Console.WriteLine("Customer ID:{0} has been deleted \n", c.CustomerID);
            Console.WriteLine("Customer list updated.");
            GetCustomerList();
        }               
    }                          
}                              
