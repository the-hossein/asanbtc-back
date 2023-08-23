using System;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Contract;

namespace RepositoryLayer.Repository
{
    
    public class ContentRepository : RepositoryBase<Content>, IContentRepository
    {
        public ContentRepository(AsanBtcDbContext Context) : base(Context) { }

       
    }
}

