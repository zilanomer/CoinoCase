using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (ECommerceContext context = new ECommerceContext() )
            {
                var result = from p in context.Products
                             join p2 in context.Categories
                             on p.CategoryId equals p2.CategoryId
                             select new ProductDetailDto
                             { 
                                 ProductId = p.ProductId, ProductName = p.ProductName,
                                 CategoryName = p2.CategoryName, UnitsInStock = p.UnitsInStock
                             };
                return result.ToList(); 
            }
        }

        
      
    }
}
