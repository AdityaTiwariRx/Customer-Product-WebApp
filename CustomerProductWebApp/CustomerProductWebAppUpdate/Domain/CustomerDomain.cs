using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerProductWebApp.Models;

namespace CustomerProductWebApp.Domain
{
    public class CustomerDomain:BaseDomain
    {

        public List<Customer> Get()
        {

            var reader = this.GetReader("select *from Customers");
            var customers = new List<Customer>();
            while (reader.Read())
            {

                var customer = new Customer();
                customer.CustomerNumber = reader.GetInt32(0);
                customer.FirstName = reader.GetString(1);
                customer.LastName = reader.GetString(2);
                customer.Email = reader.GetString(3);
                customer.Password = reader.GetString(4);
                customer.ConfirmPassword = reader.GetString(5);
                customer.MobileNumber = reader.GetString(6);
                customer.Gender = reader.GetString(7);
                customer.Address = reader.GetString(8);
                customer.DOB = reader.GetDateTime(9);
                customers.Add(customer);


            }
            return customers;
        }

        public void Add(Customer customer)
        {
            this.ExecuteNonQuery($"insert into Customers values ('{customer.FirstName}','{customer.LastName}'," +
                $"{customer.Email},'{customer.Password}','{customer.ConfirmPassword}','{customer.MobileNumber}'" +
                $"'{customer.Gender}','{customer.Address}','{customer.DOB}')");
        }
        public void Update(Customer customer)
        {
            this.ExecuteNonQuery($"update Customers set FirstName='{customer.FirstName}',LastName='{customer.LastName}'," +
                $"Email='{customer.Email}',Password='{customer.Password}',ConfirmPassword='{customer.ConfirmPassword}'," +
                $"MobileNumber='{customer.MobileNumber}',Gender='{customer.Gender}',Address='{customer.Address}',DOB='{customer.DOB}' " +
                $"where CustomerNumber = {customer.CustomerNumber}");
        }
        public void Delete(int id)
        {
            this.ExecuteNonQuery($"delete from Customers where CustomerNumber = {id}");
        }


    }
}
