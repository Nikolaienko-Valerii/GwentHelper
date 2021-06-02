using GwentHelper.DAL.EF;
using GwentHelper.DAL.Entities;
using GwentHelper.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace GwentHelper.DAL.Repos
{
    class EfUnitOfWork : IUnitOfWork
    {
        private readonly CardContext _db;
        private CardRepository _cardRepository;
        private CategoryRepository _categoryRepository;
        private KeywordRepository _keywordRepository;

        public EfUnitOfWork(DbContextOptions<CardContext> options)
        {
            _db = new CardContext(options);
        }

        public IRepository<Card> Cards => _cardRepository ??= new CardRepository(_db);

        public IRepository<Category> Categories => _categoryRepository ??= new CategoryRepository(_db);

        public IRepository<Keyword> Keywords => _keywordRepository ??= new KeywordRepository(_db);

        private bool _disposed;

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this._disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
