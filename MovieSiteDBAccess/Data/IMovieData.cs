using MovieSiteData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSiteData.Data
{
    public interface IMovieData
    {
        Task<IEnumerable<MovieModel>> GetMovies();
        Task<MovieModel> GetMovie(Guid id);
        Task InsertMovie(MovieModel movie);
        Task DeleteMovie(Guid id);
        Task UpdateMovie(MovieModel movie);
    }
}
