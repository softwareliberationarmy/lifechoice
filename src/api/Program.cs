using Application.Configuration;
using Persistence.Configuration;

[assembly:CLSCompliant(false)]

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDataContext(builder.Configuration);
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("Development", policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3030");
    });
});
builder.Services.ConfigureApplicationServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Development");

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();
await scope.ServiceProvider.UpdateDatabase().ConfigureAwait(false);

await app.RunAsync().ConfigureAwait(false);
