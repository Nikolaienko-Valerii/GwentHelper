using GwentHelper.DAL.Entities;
using System;

namespace GwentHelper.DAL.Interfaces
{
    interface IUnitOfWork: IDisposable
    {
        IRepository<Card> Cards { get; }
        IRepository<Category> Categories { get; }
        IRepository<Keyword> Keywords { get; }
        void Save();
    }
}
