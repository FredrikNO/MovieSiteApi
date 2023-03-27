using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSiteData.DbAccess;
using MovieSiteData.Model;

namespace MovieSiteData.Data
{
    public class MovieData:IMovieData
    {
        private readonly ISqlDbAccess _db;

        public MovieData(ISqlDbAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<MovieModel>> GetMovies()
        {
            return _db.GetDataFromSql<MovieModel, dynamic>("spMovie_GetAll", new { });
        }

        public async Task<MovieModel> GetMovie(Guid id)
        {
            var result = await _db.GetDataFromSql<MovieModel, dynamic>("spMovieInfo_GetAllFromId", new { Id = id });
            return result.FirstOrDefault();
        }

        public Task InsertMovie(MovieModel movie)
        {
            return _db.SendDataToSql("spMovie_InsertInto", movie);
        }

        public Task DeleteMovie(Guid id)
        {
            return _db.SendDataToSql("spMovie_Delete ", new {Id=id});
        }

        public Task UpdateMovie(MovieModel movie)
        {
            return _db.SendDataToSql("spMovie_Update", movie);
        }
    }
}
