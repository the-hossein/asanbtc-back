using System;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Contract;

namespace RepositoryLayer.Repository
{
    
    public class ContentTypeRepository : RepositoryBase<ContentType>, IContentTypeRepository
    {
        public ContentTypeRepository(AsanBtcDbContext Context) : base(Context) { }

       
    }
}

