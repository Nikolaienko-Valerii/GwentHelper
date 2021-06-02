using GwentHelper.DAL.EF;
using GwentHelper.DAL.Entities;
using GwentHelper.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GwentHelper.DAL.Repos
{
    class KeywordRepository: IRepository<Keyword>
    {
        private readonly CardContext _db;

        public KeywordRepository(CardContext context)
        {
            _db = context;
        }

        public void Create(Keyword item)
        {
            _db.Keywords.Add(item);
        }

        public void Delete(int id)
        {
            Keyword keyword = _db.Keywords.Find(id);
            if (keyword != null)
            {
                _db.Keywords.Remove(keyword);
            }
        }

        public IEnumerable<Keyword> Find(Func<Keyword, bool> predicate)
        {
            return _db.Keywords.Where(predicate).ToList();
        }

        public Keyword Get(int id)
        {
            return _db.Keywords.Find(id);
        }

        public IEnumerable<Keyword> GetAll()
        {
            return _db.Keywords;
        }

        public void Update(Keyword item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }
    }
}
