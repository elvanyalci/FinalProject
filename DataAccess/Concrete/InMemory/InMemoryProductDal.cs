using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;//global değişken referans tip _ ile kullanılır

        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitsInStock=15,UnitPrice=15},
                new Product{CategoryId=2,ProductId=1,ProductName="Kamera",UnitsInStock=500,UnitPrice=3},
                new Product{CategoryId=3,ProductId=2,ProductName="Telefon",UnitsInStock=1500,UnitPrice=2},
                new Product{CategoryId=4,ProductId=2,ProductName="Klavye",UnitsInStock=150,UnitPrice=65},
                new Product{CategoryId=5,ProductId=2,ProductName="Fare",UnitsInStock=85,UnitPrice=1},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete=null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //_products.Remove(productToDelete);
            //LİNQ
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);//tek eleman bulmaya yarar
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);//referans numarasını getirdik.
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();//where şarta uyan büütn elemanları yeni bir liste haline getirir.
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
