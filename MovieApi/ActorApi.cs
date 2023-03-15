using MovieSiteData.Data;
using MovieSiteData.Model;

namespace MovieApi
{
    public static class ActorApi
    {
        public static void ConfigureActorApi(this WebApplication app)
        {
            app.MapGet("/Actors", GetActors);
            app.MapGet("/Actors/{id}", GetActor);
            app.MapPost("/Actors", InsertActor);
            app.MapPut("/Actors", UpdateActor);
            app.MapDelete("/Actors", DeleteActor);
        }

        private static async Task<IResult> GetActors(IActorData data)
        {
            try
            {
                return Results.Ok(await data.GetAllActors());
            }
            catch (Exception ex)
            {
               return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetActor(Guid id, IActorData data)
        {
            try
            {
                return Results.Ok(await data.GetActor(id));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertActor(ActorModel actor, IActorData data)
        {
            try
            {
                await data.InsertActor(actor);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateActor(ActorModel actor, IActorData data)
        {
            try
            {
                await data.UpdateActor(actor);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteActor(Guid id, IActorData data)
        {
            try
            {
                await data.DeleteActor(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
