using MovieSiteData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSiteData.Data
{
    public interface ICategoryData
    {
        Task<IEnumerable<CategoryModel>> GetAll();
        Task InsertCategory(CategoryModel category);
        Task UpdateCategory(CategoryModel category);
        Task DeleteCategory(int id);
    }
}
