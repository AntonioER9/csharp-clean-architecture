using CA_ApplicationLayer;
using CA_InterfaceAdapters_Data;
using CA_InterfaceAdapters_Models;
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
builder.Services.AddScoped<IRepository<BeerModel>, Repository>();
builder.Services.AddScoped<GetBeerUseCase<BeerModel>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/beer", async (GetBeerUseCase<BeerModel> beerUseCase) =>
{
    return await beerUseCase.ExecuteAsync();
})
.WithName("beers")
.WithOpenApi();

app.Run();