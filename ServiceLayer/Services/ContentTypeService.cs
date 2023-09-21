using System.Linq.Expressions;
using ServiceLayer.Contract;
using RepositoryLayer.Contract;
using DataLayer.Entities;

namespace ServiceLayer.Services
{
    public class ContentTypeService : IContentTypeService
    {
        private readonly IContentTypeRepository _ContentType;
        private readonly IDapperRepository _Dapper;
        public ContentTypeService(IContentTypeRepository ContentType, IDapperRepository Dapper)
        {

            _ContentType = ContentType;
            _Dapper = Dapper;
        }

        public async Task<ContentType> FindByCondition(Expression<Func<ContentType, bool>> Condition)
        {
            try
            {
                return _ContentType.FindByCondition(Condition);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

                return null;
            }
        }

        public async Task<IQueryable<ContentType>> FindAll()
        {

            try
            {
                return await _ContentType.FindAll();
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
                var TheContentType = _ContentType.FindByCondition(a => a.IntId == id);
                var Result = _ContentType.Delete(TheContentType);
                return Result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public async Task<IQueryable<ContentType>> FindListByCondition(Expression<Func<ContentType, bool>> Condition)
        {

            try
            {
                return _ContentType.FindListByCondition(Condition);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

                return null;
            }
        }
        public async Task<int?> GetIdWithCondition(Expression<Func<ContentType, bool>> Condition)
        {
            try
            {
                var FoundRecord = _ContentType.FindByCondition(Condition);
                if (FoundRecord != null)
                    return FoundRecord.IntId;
                else
                    return null;
            }
            catch (Exception)
            {
                Console.Write("This ContentType Is not Exist");

                return null;
            }

        }

        public async Task<ContentType> GetWithId(int Id)
        {
            try
            {
                ContentType FindBuilding = _ContentType.FindByCondition(c => c.IntId == Id);
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

        public async Task<ContentType> Create(ContentType NewContentType)
        {
            try
            {
                if (await GetWithId(NewContentType.IntId) == null)
                {
                    ContentType GetRecord = _ContentType.Create(NewContentType);
                    return GetRecord;
                }
                else
                {
                    Console.WriteLine($"This ClassesCourse Name Is Already Exist => ClassesCourseName = {NewContentType.IntId}");

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

