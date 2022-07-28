using DeliveryOrders_3.Domain;
using DeliveryOrders_3.Domain.Repositories.Abstract;
using DeliveryOrders_3.Domain.Repositories.EntityFramework;
using DeliveryOrders_3.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//��������� ������� ��� ������������ � ������������� (MVC)
builder.Services.AddControllersWithViews();// Add services to the container.
builder.Configuration.Bind("Project", new Config()); //������ ���� ������� �� service\config

//���������� ������ ���������� ���������� � �������� ��������
builder.Services.AddTransient<IDeliveryOrdersRepository, EFDeliveryOrdersRepository>();
builder.Services.AddTransient<DataManager>();

//���������� �������� ��
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

//var connectionString = builder.Configuration.GetConnectionString("AppDb");
//builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection(); //
app.UseStaticFiles(); //��������� ��������� ������ (js css � ��)

app.UseRouting(); //���������� ������� �������������

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
