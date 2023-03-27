using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSiteData.DbAccess;
using MovieSiteData.Model;

namespace MovieSiteData.Data
{
    public class CategoryData:ICategoryData
    {
        private readonly ISqlDbAccess _db;

        public CategoryData(ISqlDbAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<CategoryModel>> GetAll()
        {
            return _db.GetDataFromSql<CategoryModel, dynamic>("spCategory_GetAll", new { });
        }

        public Task InsertCategory(CategoryModel category)
        {
            return _db.SendDataToSql("spCategory_InsertInto", category);
        }

        public Task UpdateCategory(CategoryModel category)
        {
            return _db.SendDataToSql("spCategory_Update", category);
        }

        public Task DeleteCategory(int id)
        {
            return _db.SendDataToSql("spCategory_Delete", new {Id=id});
        }
    }
}
