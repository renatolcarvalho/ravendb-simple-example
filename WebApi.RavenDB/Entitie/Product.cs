using System;

namespace WebApi.RavenDB.Entitie
{
    public class Category
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int UnitsInStock { get; set; }
        public ProductDetails? ProductDetails { get; set; }
    }

    public struct ProductDetails
    {
        public string Observation { get; set; }
        public DateTime Created { get; set; }
    }
}
