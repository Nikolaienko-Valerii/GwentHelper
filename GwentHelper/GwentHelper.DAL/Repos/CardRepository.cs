using GwentHelper.DAL.EF;
using GwentHelper.DAL.Entities;
using GwentHelper.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GwentHelper.DAL.Repos
{
    class CardRepository : IRepository<Card>
    {
        private readonly CardContext _db;

        public CardRepository(CardContext context)
        {
            _db = context;
        }

        public void Create(Card item)
        {
            _db.Cards.Add(item);
        }

        public void Delete(int id)
        {
            Card card = _db.Cards.Find(id);
            if (card!=null)
            {
                _db.Cards.Remove(card);
            } 
        }

        public IEnumerable<Card> Find(Func<Card, bool> predicate)
        {
            return _db.Cards.Where(predicate).ToList();
        }

        public Card Get(int id)
        {
            return _db.Cards.Find(id);
        }

        public IEnumerable<Card> GetAll()
        {
            return _db.Cards;
        }

        public void Update(Card item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }
    }
}
