using Microsoft.EntityFrameworkCore;
using StudentAdmission.API.Middleware;
using StudentAdmission.API.ServiceExtensions;
using StudentAdmission.DAL.Config;
using StudentAdmission.MappingProfile;


var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureRepositoryWrapper();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Conn")));

//builder.Services.AddScoped<IStudentRepository, StudentRepository>();
//builder.Services.AddScoped<IStudentSubjectRepository, StudentSubjectService>();


//Adding Automapper

builder.Services.AddAutoMapper(typeof(MappingProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseMiddleware<ErrorHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
