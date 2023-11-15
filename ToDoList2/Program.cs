using ToDoList2.Core.Common.Extensions.ErrorHandler;
using ToDoList2.Core.Common.Extensions.Swaggers;
using ToDoList2.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerConfiguration(builder.Configuration);
builder.Services.AddApplicationPersistence(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerConfiguration();
}
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});


app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

app.UseErrorMiddleware();

app.MapControllers();

app.Run();