using HostingAllForOne.Services.GreaterThanOrLessThan;
using HostingAllForOne.Services.MadLib;
using HostingAllForOne.Services.NameTime;
using HostingAllForOne.Services.OddOrEven;
using HostingAllForOne.Services.ReverseItAlphanumeric;
using HostingAllForOne.Services.ReverseItNumbers;
using HostingAllForOne.Services.SayHello;
using HostingAllForOne.Services.Sum;
using MiniChallengeEightToTen_Endpoints.Services.EightBall;
using MiniChallengeEightToTen_Endpoints.Services.RestaurantPicker;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEightBallService, EightBallService>();
builder.Services.AddScoped<IGreaterThanOrLessThanService, GreaterThanOrLessThanService>();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<INameTimeService, NameTimeService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IRestaurantPickerService, RestaurantPickerService>();
builder.Services.AddScoped<IReverseItAlphanumericService, ReverseItAlphanumeric>();
builder.Services.AddScoped<IReverseItNumbersService, ReverseItNumbersService>();
builder.Services.AddScoped<ISayHelloService, SayHellosService>();
builder.Services.AddScoped<ISumService, SumService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
