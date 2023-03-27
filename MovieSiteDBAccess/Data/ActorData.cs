using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSiteData.DbAccess;
using MovieSiteData.Model;

namespace MovieSiteData.Data
{
    public class ActorData:IActorData
    {
        private readonly ISqlDbAccess _db;

        public ActorData(ISqlDbAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<ActorModel>> GetAllActors()
        {
            return _db.GetDataFromSql<ActorModel, dynamic>("spActor_GetAll", new { });
        }

        public async Task<ActorModel> GetActor(Guid id)
        {
            var result = await _db.GetDataFromSql<ActorModel, dynamic>("spActor_GetOneFromId", new { Id = id });
            return result.FirstOrDefault();
        }

        public Task InsertActor(ActorModel actor)
        {
            return _db.SendDataToSql("spActor_InsertInto", actor);
        }

        public Task DeleteActor(Guid id)
        {
            return _db.SendDataToSql("spActor_Delete", new {Id=id});
        }

        public Task UpdateActor(ActorModel actor)
        {
            return _db.SendDataToSql("spActor_Update", actor);
        }
    }
}
