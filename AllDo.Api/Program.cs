using AllDo.Domain;
using AllDo.Infrastructure.Data;
using AllDo.Infrastructure.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


builder.Services.AddDbContext<AllDoDbContext>();
builder.Services.AddScoped<IRepository<BugDto>, BugRepository>();
builder.Services.AddScoped<IRepository<FeatureDto>, FeatureRepository>();
builder.Services.AddScoped<IRepository<TodoTaskDto>, TodoTaskRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

AllDoDbContext.EnsureCreated();

// app.MapGet("/todos", async (IRepository<TodoTask> repo) => await repo.AllAsync()).Produces<TodoTask[]>(StatusCodes.Status200OK);


app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
