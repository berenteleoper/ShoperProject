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
    public class ProductPriceService : IProductPriceService
    {
        private readonly IProductPriceService _productPriceService;
        public ProductPriceService()
        {
            this._productPriceService = new ProductPriceService();
        }
        public ProductPrice Add(ProductPrice entity)
        {
            return _productPriceService.Add(entity);
        }

        public ProductPrice Delete(ProductPrice entity)
        {
            return _productPriceService.Delete(entity);
        }

        public ProductPrice Get(int id)
        {
            return _productPriceService.Get(id);
        }

        public IEnumerable<ProductPrice> GetAll()
        {
            return _productPriceService.GetAll();
        }

        public IEnumerable<ProductPrice> GetExp(Expression<Func<ProductPrice, bool>> predicate)
        {
            return _productPriceService.GetExp(predicate);
        }

        public ProductPrice Update(ProductPrice entity)
        {
            return _productPriceService.Update(entity);
        }
    }
}
