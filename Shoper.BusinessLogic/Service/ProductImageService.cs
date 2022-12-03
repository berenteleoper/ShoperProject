using Shoper.BusinessLogic.Interface;
using Shoper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shoper.BusinessLogic.Service
{
    public class ProductImageService : IProductImageService
    {
        private readonly IProductImageService _productImageService;
        public ProductImageService()
        {
            this._productImageService = new ProductImageService();
        }
        public ProductImage Add(ProductImage entity)
        {
            return _productImageService.Add(entity);
        }

        public ProductImage Delete(ProductImage entity)
        {
            return _productImageService.Delete(entity);
        }

        public ProductImage Get(int id)
        {
            return _productImageService.Get(id);
        }

        public IEnumerable<ProductImage> GetAll()
        {
            return _productImageService.GetAll();
        }

        public IEnumerable<ProductImage> GetExp(Expression<Func<ProductImage, bool>> predicate)
        {
            return _productImageService.GetExp(predicate);
        }

        public ProductImage Update(ProductImage entity)
        {
            return _productImageService.Update(entity);
        }
    }
}
