var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var drivers = new List<Driver>
{
    new Driver { Id = 1, Name = "Hamilton" },
    new Driver { Id = 2, Name = "Schumacher" },
};
app.UseHttpsRedirection();
app.MapGet("api/driver", () => drivers);


app.Run();

class Driver
{
    public int Id { get; set; }
    public string Name { get; set; }
}