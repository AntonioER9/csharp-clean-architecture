using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapters_Data;
using CA_InterfaceAdapters_Mappers;
using CA_InterfaceAdapters_Mappers.Dtos.Requests;
using CA_InterfaceAdapters_Models;
using CA_InterfaceAdapters_Presenters;
using CA_InterfaceAdapters_Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependencias
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IRepository<Beer>, Repository>();
builder.Services.AddScoped<IPresenter<Beer, BeerViewModel>, BeerPresenter>();
builder.Services.AddScoped<IMapper<BeerRequestDTO, Beer>, BeerMapper>();

builder.Services.AddScoped<GetBeerUseCase<Beer, BeerViewModel>>();
builder.Services.AddScoped<AddBeerUseCase<BeerRequestDTO>>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/beer", async (GetBeerUseCase<Beer, BeerViewModel> beerUseCase) =>
{
    return await beerUseCase.ExecuteAsync();
})
.WithName("beers")
.WithOpenApi();

app.MapPost("/beer", async (BeerRequestDTO beerRequest, AddBeerUseCase<BeerRequestDTO> beerUseCase) =>
{
    await beerUseCase.ExecuteAsync(beerRequest);
    return Results.Created("/beer", beerRequest);
})
.WithName("addBeer")
.WithOpenApi();


app.Run();