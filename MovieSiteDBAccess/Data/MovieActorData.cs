using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSiteData.DbAccess;
using MovieSiteData.Model;

namespace MovieSiteData.Data
{
    public class MovieActorData:IMovieActorData
    {
        private readonly ISqlDbAccess _db;

        public MovieActorData(ISqlDbAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<MovieActorModel>> GetAll()
        {
            return _db.GetDataFromSql<MovieActorModel, dynamic>("spMovieActor_GetAll", new { });
        }

        public Task InsertInto(MovieActorModel mAData)
        {
            return _db.SendDataToSql("spMovieActor_InsertInto", mAData);
        }

        public Task UpdateMovie(MovieActorModel mAData)
        {
            return _db.SendDataToSql("spMovieActor_UpdateActor", mAData);
        }
        
        public Task UpdateActor(MovieActorModel mAData)
        {
            return _db.SendDataToSql("spMovieActor_UpdateMovie", mAData);
        }

        public Task DeleteWithMovieId(Guid id)
        {
            return _db.SendDataToSql("spMovieActor_Delete", id);
        }
    }
}
