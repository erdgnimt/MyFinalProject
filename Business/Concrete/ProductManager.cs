﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService; 
        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            var result = BusinessRules.Run(CheckIfProductCountOfCategoryCorrect(product.ProductId), CheckIfProductNameExists(product.ProductName),CheckIfCategoryLimitExceded());
            if (result != null)
            {
                return result;

            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);




        }

        public IDataResult<List<Product>> GetAll()
        {
            //if (DateTime.Now.Hour == 22)
            //{
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
            //}
            //else
            //{

            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}

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
        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;

            if (result >= 10)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Any();

            if (result == true)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
