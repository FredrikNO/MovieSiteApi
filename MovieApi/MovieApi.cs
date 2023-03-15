using MovieSiteData.Data;
using MovieSiteData.Model;
namespace MovieApi
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            app.MapGet("/Movies", GetMovies);
            app.MapGet("/Movies/{id}", GetMove);
            app.MapPost("/Movies", InsertMovie);
            app.MapPut("/Movies", UpdateMove);
            app.MapDelete("/Movies", DeleteMovie);
        }

        private static async Task<IResult> GetMovies(IMovieData data)
        {
            try
            {
                return Results.Ok(await data.GetMovies());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetMove(Guid id, IMovieData data)
        {
            try
            {
                var result = await data.GetMovie(id);
                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertMovie(MovieModel movie, IMovieData data)
        {
            try
            {
                await data.InsertMovie(movie);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateMove(MovieModel movie, IMovieData data)
        {
            try
            {
                await data.UpdateMovie(movie);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteMovie(Guid id, IMovieData data)
        {
            try
            {
                await data.DeleteMovie(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
