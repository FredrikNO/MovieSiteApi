using MovieApi;
using MovieSiteData.Data;
using MovieSiteData.DbAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IMovieData, MovieData>();
builder.Services.AddSingleton<ISqlDbAccess, SqlDbAccess>();
builder.Services.AddSingleton<IActorData, ActorData>();


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

app.ConfigureMovieApi();
app.ConfigureActorApi();

app.Run();
