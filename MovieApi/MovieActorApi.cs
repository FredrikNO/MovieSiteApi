using MovieSiteData.Data;
using MovieSiteData.Model;

namespace MovieApi
{
    public static class MovieActorApi
    {
        public static void ConfigureMovieActorApi(this WebApplication app)
        {
            app.MapGet("/MovieActor", GetAll);
            app.MapPost("/MovieActor", InsertInto);
            app.MapPut("/MovieActor", UpdateActor);
            //app.MapPut("/MovieActor", UpdateMovie);
            app.MapDelete("/MovieActor", Delete);
        }

        private static async Task<IResult> GetAll(IMovieActorData data)
        {
            try
            {
                return Results.Ok(await data.GetAll());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertInto(MovieActorModel movieActor, IMovieActorData data)
        {
            try
            {
                await data.InsertInto(movieActor);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateActor(MovieActorModel movieActor, IMovieActorData data)
        {
            try
            {
                await data.UpdateActor(movieActor);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateMovie(MovieActorModel movieActor, IMovieActorData data)
        {
            try
            {
                await data.UpdateMovie(movieActor);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> Delete(Guid id, IMovieActorData data)
        {
            try
            {
                await data.DeleteWithMovieId(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
