using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public InMemoryCategoryDal()
        {
            _categories = new List<Category> {
                new Category { CategoryId = 1, CategoryName="Beyaz Eşya"},
                new Category { CategoryId = 2,CategoryName="Teknoloji"},
                new Category { CategoryId = 3,CategoryName="Giyim"},
                new Category { CategoryId = 4,CategoryName="Hırdavat"}
            };
        }
        public List<Category> GetAll()
        {
            return _categories;
        }
    }
}
