using MovieSiteData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSiteData.Data
{
    public interface IMovieActorData
    {
        Task<IEnumerable<MovieActorModel>> GetAll();
        Task InsertInto(MovieActorModel mAData);
        Task UpdateMovie(MovieActorModel mAData);
        Task UpdateActor(MovieActorModel mAData);
        Task DeleteWithMovieId(Guid id);
    }
}
