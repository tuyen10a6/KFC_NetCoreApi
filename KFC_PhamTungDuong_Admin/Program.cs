using BUS;
using BUS.BusAdmin;
using BUS.IBus;
using DAL.DALADMIN;
using DAL.Helper;
using DAL.Iterface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<ISanPhamAdminRepository, SanPhamAdminRepository>();
builder.Services.AddTransient<ISanPhamAdminBus,  ProductAdminBus>();
builder.Services.AddTransient<IDanhMucAdmin, DanhMucAdminRepository>();
builder.Services.AddTransient<IDanhMucAdminBus, DanhMucAdminBus>();
builder.Services.AddTransient<INhaCungCapAdminRepository, NhaCungCapAdminRepository>();
builder.Services.AddTransient<INhaCungCapBus, NhaCungCapAdminBus>();
builder.Services.AddCors(p => p.AddPolicy("MyCors", build => { build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader(); }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("MyCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
