using System;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;
using ServiceLayer.Contract;
using RepositoryLayer.Contract;
using DataLayer.Entities;

namespace ServiceLayer.Services
{
    public class ContentService : IContentService
    {
        private readonly IContentRepository _Content;
        private readonly IDapperRepository _Dapper;
        public ContentService(IContentRepository Content, IDapperRepository Dapper)
        {

            _Content = Content;
            _Dapper = Dapper;
        }

        public async Task<Content> FindByCondition(Expression<Func<Content, bool>> Condition)
        {
            try
            {
                return _Content.FindByCondition(Condition);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

                return null;
            }
        }

        public async Task<IQueryable<object>> FindAll()
        {

            try
            {
                return await _Dapper.GetAllContent();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

                return null;
            }
        }

        public async Task<bool> Delete(int id)
        {

            try
            {
                var TheContent = _Content.FindByCondition(a => a.IntID == id);
                var Result = _Content.Delete(TheContent);
                return Result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public async Task<IQueryable<Content>> FindListByCondition(Expression<Func<Content, bool>> Condition)
        {

            try
            {
                return _Content.FindListByCondition(Condition);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

                return null;
            }
        }
        public async Task<int?> GetIdWithCondition(Expression<Func<Content, bool>> Condition)
        {
            try
            {
                var FoundRecord = _Content.FindByCondition(Condition);
                if (FoundRecord != null)
                    return FoundRecord.IntID;
                else
                    return null;
            }
            catch (Exception)
            {
                Console.Write("This Content Is not Exist");

                return null;
            }

        }

        public async Task<Content> GetWithId(int Id)
        {
            try
            {
                Content FindBuilding = _Content.FindByCondition(c => c.IntID == Id);
                if (FindBuilding == null)
                {
                    Console.WriteLine($"Can not Find Building With {Id} Id In Db");

                    return null;
                }
                return FindBuilding;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public async Task<Content> Create(Content NewContent)
        {
            try
            {
                if (await GetWithId(NewContent.IntID) == null)
                {
                    Content GetRecord = _Content.Create(NewContent);
                    return GetRecord;
                }
                else
                {
                    Console.WriteLine($"This ClassesCourse Name Is Already Exist => ClassesCourseName = {NewContent.IntID}");

                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

                return null;
            }

        }
    }
}

