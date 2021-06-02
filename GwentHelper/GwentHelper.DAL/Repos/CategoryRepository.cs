using GwentHelper.DAL.EF;
using GwentHelper.DAL.Entities;
using GwentHelper.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GwentHelper.DAL.Repos
{
    class CategoryRepository: IRepository<Category>
    {
        private readonly CardContext _db;

        public CategoryRepository(CardContext context)
        {
            _db = context;
        }

        public void Create(Category item)
        {
            _db.Categories.Add(item);
        }

        public void Delete(int id)
        {
            Category category = _db.Categories.Find(id);
            if (category != null)
            {
                _db.Categories.Remove(category);
            }
        }

        public IEnumerable<Category> Find(Func<Category, bool> predicate)
        {
            return _db.Categories.Where(predicate).ToList();
        }

        public Category Get(int id)
        {
            return _db.Categories.Find(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _db.Categories;
        }

        public void Update(Category item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }
    }
}
