using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (DateTime.Now.Hour == 22)
            {
                _productDal.Add(product);
                return new SuccessResult(Messages.ProductAdded);               
            }
            else
            {

                return new ErrorResult(Messages.MaintenanceTime);
            }
           
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
            }
            else
            {

                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id), Messages.ProductListed);
            }
            else
            {

                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }          
        }

        public IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max), Messages.ProductListed);
            }
            else
            {

                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

           
        }

        public IDataResult<Product> GetById(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id), Messages.ProductListed);
            }
            else
            {

                return new ErrorDataResult<Product>(Messages.MaintenanceTime);
            }           
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {

            if (DateTime.Now.Hour == 22)
            {
                return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(), Messages.ProductListed);
            }
            else
            {

                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }
           
        }
    }
}
