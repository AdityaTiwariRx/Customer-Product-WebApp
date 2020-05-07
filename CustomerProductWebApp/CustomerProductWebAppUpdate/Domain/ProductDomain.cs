using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerProductWebApp.Models;

namespace CustomerProductWebApp.Domain
{
    public class ProductDomain:BaseDomain
    {
        public List<Product> Get()
        {

            var reader = this.GetReader("select *from Products");
            var products = new List<Product>();
            while (reader.Read())
            {

                var product = new Product();
                product.ProductCode = reader.GetInt32(0);
                product.ProductName = reader.GetString(1);
                product.Brand = reader.GetString(2);
                product.ProductPrice = reader.GetInt32(3);
                product.ProductStatus = reader.GetBoolean(4);
                
                products.Add(product);


            }
            return products;
        }

        public void Add(Product product)
        {
            this.ExecuteNonQuery($"insert into Products values ('{product.ProductName}','{product.Brand}'," +
                $"{product.ProductPrice},'{product.ProductStatus}')");
        }

        public void Update(Product product)
        {
            this.ExecuteNonQuery($"update Products set ProductName='{product.ProductName}',Brand='{product.Brand}'," +
                $"ProductPrice='{product.ProductPrice}',ProductStatus='{product.ProductStatus}' " +
                $"where ProductCode = {product.ProductCode}");
        }

        public void Delete(int id)
        {
            this.ExecuteNonQuery($"delete from Products where ProductCode = {id}");
        }
    }
}
