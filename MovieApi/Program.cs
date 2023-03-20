using System.ComponentModel;
using System.Data.Common;
using MovieApi;
using MovieSiteData.Data;
using MovieSiteData.DbAccess;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IMovieData, MovieData>();
builder.Services.AddSingleton<ISqlDbAccess, SqlDbAccess>();
builder.Services.AddSingleton<IActorData, ActorData>();
builder.Services.AddSingleton<ICategoryData, CategoryData>();
builder.Services.AddSingleton<IMovieActorData, MovieActorData>();

builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.WithOrigins("http://127.0.0.1:5500/")
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
}));

//Put dependencies here builder.Services.addSingleten or scooped etc..

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Put Api code here
app.UseCors("MyPolicy");
app.ConfigureMovieApi();
app.ConfigureActorApi();
app.ConfigureCategoryApi();
app.ConfigureMovieActorApi();

//Brukes for å bruke html taggen i eget prosjekt
//app.UseStaticFiles();

app.Run();
