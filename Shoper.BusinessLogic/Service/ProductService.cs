using Shoper.BusinessLogic.Interface;
using Shoper.Data.Interface;
using Shoper.Data.Repository;
using Shoper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shoper.BusinessLogic.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductService _productService;   
        public ProductService(IProductService productService)
        {
            this._productService = productService;
        }
        public Product Add(Product entity)
        {
            return _productService.Add(entity);
        }

        public Product Delete(Product entity)
        {
            return _productService.Delete(entity);
        }

        public Product Get(int id)
        {
            return _productService.Get(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productService.GetAll();
        }

        public IEnumerable<Product> GetExp(Expression<Func<Product, bool>> predicate)
        {
            return _productService.GetExp(predicate);
        }

        public Product Update(Product entity)
        {
            return _productService.Update(entity);
        }
    }
}
