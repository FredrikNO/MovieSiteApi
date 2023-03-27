using MovieSiteData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSiteData.Data
{
    public interface IActorData
    {
        Task<IEnumerable<ActorModel>> GetAllActors();
        Task<ActorModel> GetActor(Guid id);
        Task InsertActor(ActorModel actor);
        Task DeleteActor(Guid id);
        Task UpdateActor(ActorModel actor);
    }
}
