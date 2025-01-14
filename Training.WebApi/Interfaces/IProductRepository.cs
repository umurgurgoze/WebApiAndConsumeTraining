﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Training.WebApi.Data;

namespace Training.WebApi.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllAsync();
        public Task<Product> GetByIdAsync(int id);
        public Task<Product> CreateAsync(Product product);
        public Task UpdateAsync(Product product);
        public Task RemoveAsync(int id);
    }
}
