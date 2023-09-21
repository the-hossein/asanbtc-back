using System;
using DataLayer.Entities;

namespace RepositoryLayer.Contract
{
    public interface IDapperRepository
    {
        Task<IQueryable<object>> GetAllContent(int ContentTypeId);
    }
}

