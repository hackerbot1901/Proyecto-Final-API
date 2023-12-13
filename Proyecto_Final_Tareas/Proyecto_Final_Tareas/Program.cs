using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Proyecto_Final_Tareas.Entities;
using Proyecto_Final_Tareas.Repositories.ProyectoRepositories;
using Proyecto_Final_Tareas.Repositories.ProyectoRepository;
using Proyecto_Final_Tareas.Services.ProyectoService;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddControllers();

// Configurar Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrar las dependencias
builder.Services.AddScoped<IProyectoRepository, ProyectoRepository>();
builder.Services.AddScoped<IProyectoService, ProyectoService>();
builder.Services.AddDbContext<ProyectoTareasContext>();


var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
