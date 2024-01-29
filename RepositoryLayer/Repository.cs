using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Core;
using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _db;
        public Repository(AppDbContext db) 
        {
            _db = db;

        }

        public IQueryable<Product> GetProducts()
        {
            return _db.Product;
        }


        public async Task<Product> AddProduct(Product product)
        {
            _db.Product.Add(product);
            await _db.SaveChangesAsync();
            return product;
        }

    }
}
