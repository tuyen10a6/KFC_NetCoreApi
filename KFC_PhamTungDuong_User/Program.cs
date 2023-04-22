using BUS.BusUser;
using BUS.IBus;
using DAL.DALUSER;
using DAL.Helper;
using DAL.Iterface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<ISanPhamRepository, SanPhamUserRepository>();
builder.Services.AddTransient<ISanPhamUserBus, SanPhamBus>();
builder.Services.AddTransient<IDanhMucRepository, DanhMucUserRepository>();
builder.Services.AddTransient<IDanhMucUserBus, DanhMucBus>();
builder.Services.AddTransient<IOrderRepository, OrderUserRepository>();
builder.Services.AddTransient<IOrderUserBus, OrderUserBus>();
builder.Services.AddTransient<ISlideRepository, SlideRepository>();
builder.Services.AddTransient<ISlideUserBus, SlideBus>();
builder.Services.AddTransient<IChiNhanhRepository, ChiNhanhUserRepository>();
builder.Services.AddTransient<IChiNhanhUserBus, ChiNhanhBus>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
builder.Services.AddCors(p => p.AddPolicy("MyCors", build => { build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader(); }));
app.UseCors("MyCors");


app.UseAuthorization();

app.MapControllers();

app.Run();
