using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.RavenDB.Entitie;

namespace WebApi.RavenDB.Database
{
    public class ProductRepository : RavenDbContext
    {
        public void SaveNewProduct()
        {
            using (IDocumentSession session = DocumentStore.OpenSession())
            {
                Category category = new Category
                {
                    Name = "Eletronics"
                };

                session.Store(category);

                Product product = new Product
                {
                    Name = "Smartphone 5.0",
                    Category = category.Id,
                    UnitsInStock = 10,
                    ProductDetails = new ProductDetails()
                    {
                        Observation = "New device.",
                        Created = DateTime.Now
                    }
                };

                session.Store(product);
                session.SaveChanges();
            }
        }

        public IEnumerable<string> GetListOfNames()
        {
            using (IDocumentSession session = DocumentStore.OpenSession())
            {
                var productNamesQuery = from products in session.Query<Product>()
                                        select products.Name;

                return productNamesQuery.ToList();
            }
        }       
    }
}