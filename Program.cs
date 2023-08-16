using EF_Tutorial;
using EF_Tutorial.Data;
using EF_Tutorial.Interface;
using EF_Tutorial.Repository;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// builder.Services.AddTransient<Seed>();
builder.Services.AddScoped<IUser, UserRepository>();
builder.Services.AddScoped<IPump, PumpRepository>();
builder.Services.AddScoped<IJsondata, JsonDataRepository>();
builder.Services.AddScoped<IUserAuth, UserAuthRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
             policy =>
             {
                 policy.WithOrigins("http://localhost:5148", "http://localhost:3000")
               .AllowAnyHeader()
               .AllowAnyMethod()
               .AllowCredentials();
             });
});
var app = builder.Build();
// using var scope = app.Services.CreateScope();
// var services = scope.ServiceProvider;

// try {
//     var context = services.GetRequiredService<DataContext>();
//     await context.Database.MigrateAsync();
//     await Seed.SeedDataContext(context);
// }
// catch (Exception ex) {
//     var logger = services.GetRequiredService<ILogger<Program>>();
// }

// SeedData(app);

// void SeedData(IHost app)
// {
//     var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

//     using (var scope = scopedFactory.CreateScope())
//     {
//         var service = scope.ServiceProvider.GetService<Seed>();\


//         service.SeedDataContext();
//     }
// }

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
