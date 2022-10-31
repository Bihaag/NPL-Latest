using GymServices.Membership;
using GymServices.Membership.Interface;
using GymServices.OrderService;
using GymServices.OrderService.Interface;
using GymServices.ProgressService;
using GymServices.ProgressService.Interface;
using GymServices.TrainerService;
using GymServices.TrainerService.Interface;
using GymServices.UsersService;
using GymServices.Utils;
using GymServices.Utils.Interface;
using GymServices.Workout;
using GymServices.Workout.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IUsers,Users>();
builder.Services.AddTransient<IOrders, Orders>();
builder.Services.AddTransient<ITrainer, Trainer>();
builder.Services.AddTransient<IProgress, Progress>();
builder.Services.AddTransient<IMembership, Membership>();
builder.Services.AddTransient<IWorkout, Workout>();
builder.Services.AddScoped<IMail, Mail>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(options => options.WithOrigins("*").AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
