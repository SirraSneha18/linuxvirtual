var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

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

app.UseHttpsRedirection();

app.UseAuthorization();

// Map controllers with virtual paths
app.MapControllerRoute(
    name: "api1",
    pattern: "api/api1/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "api2",
    pattern: "api/api2/{controller=Home}/{action=Index}/{id?}");

app.Run();
