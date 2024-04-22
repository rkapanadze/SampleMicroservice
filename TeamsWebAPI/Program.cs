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

var teams = new List<Team>
{
    new Team { Id = 1, Name = "Mercedes" },
    new Team { Id = 2, Name = "Ferrari" },
};
app.UseHttpsRedirection();
app.MapGet("api/team", () => teams);


app.Run();

class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
}