using Microsoft.EntityFrameworkCore;
using SportSeeV2.Server.Data;

var builder = WebApplication.CreateBuilder(args);

var folder = Environment.SpecialFolder.LocalApplicationData;
var path = Environment.GetFolderPath(folder);
var connectionString = $"Data Source={Path.Join(path, "sportsee.db")}";

builder.Services.AddDbContext<SportSeeDbContext>(options =>
{
    options.UseSqlite(connectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddScoped<IUserMainRepository, UserMainRepository>();
builder.Services.AddScoped<IActivitySessionRepository, ActivitySessionRepository>();
builder.Services.AddScoped<IUserAverageSessionRepository, UserAverageSessionsRepository>();
builder.Services.AddScoped<IUserPerformanceRepository, UserPerformanceRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(p => p.WithOrigins("https://localhost:5173").AllowAnyHeader().AllowAnyMethod());
app.UseCors(p => p.WithOrigins("https://portfolio-sportseev2.netlify.app").AllowAnyHeader().AllowAnyMethod());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
