using DeliveryOrders_3.Domain;
using DeliveryOrders_3.Domain.Repositories.Abstract;
using DeliveryOrders_3.Domain.Repositories.EntityFramework;
using DeliveryOrders_3.Service;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Http;
using JavaScriptEngineSwitcher.V8;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using React.AspNet;



var builder = WebApplication.CreateBuilder(args);

//добавляем сервисы для контроллеров и представлений (MVC)
builder.Services.AddControllersWithViews();// Add services to the container.
builder.Configuration.Bind("Project", new Config()); //биндим файл конфига из service\config

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddReact();

// Make sure a JS engine is registered, or you will get an error!
builder.Services.AddJsEngineSwitcher(options => options.DefaultEngineName = V8JsEngine.EngineName)
  .AddV8();



//подключаем нужный функционал приложения в качестве сервисов
builder.Services.AddTransient<IDeliveryOrdersRepository, EFDeliveryOrdersRepository>();
builder.Services.AddTransient<DataManager>();

//подключаем контекст БД
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

// Initialise ReactJS.NET. Must be before static files.
app.UseReact(config =>
{
    // If you want to use server-side rendering of React components,
    // add all the necessary JavaScript files here. This includes
    // your components as well as all of their dependencies.
    // See http://reactjs.net/ for more information. Example:
    //config
    //  .AddScript("~/js/First.jsx")
    //  .AddScript("~/js/Second.jsx");

    // If you use an external build too (for example, Babel, Webpack,
    // Browserify or Gulp), you can improve performance by disabling
    // ReactJS.NET's version of Babel and loading the pre-transpiled
    // scripts. Example:
    //config
    //  .SetLoadBabel(false)
    //  .AddScriptWithoutTransform("~/js/bundle.server.js");
});



app.UseStaticFiles(); //поддержка статичных файлов (js css и тд)

app.UseRouting(); //подключаем систему маршрутизации

app.MapControllerRoute(
name: "default",
pattern: "{controller=CreateOrder}/{action=Create}/{id?}");

app.Run();



/////////////////////////////////////////////////////////////
