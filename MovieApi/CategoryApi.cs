using MovieSiteData.Data;
using MovieSiteData.Model;

namespace MovieApi
{
    public static class CategoryApi
    {
        public static void ConfigureCategoryApi(this WebApplication app)
        {
            app.MapGet("/Categories", GetAll);
            app.MapPost("/Categories", InsertInto);
            app.MapPut("/Categories", Update);
            app.MapDelete("/Categories", Delete);
        }

        private static async Task<IResult> GetAll(ICategoryData data)
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

        private static async Task<IResult> InsertInto(CategoryModel category, ICategoryData data)
        {
            try
            {
                await data.InsertCategory(category);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> Delete(int id, ICategoryData data)
        {
            try
            {
                await data.DeleteCategory(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> Update(CategoryModel category, ICategoryData data)
        {
            try
            {
                await data.UpdateCategory(category);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
