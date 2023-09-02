using PAS.DBEngine;
using PAS.Repository.Implementation;
using PAS.Repository.Interface;
using PAS.Serivce.Implementation;
using PAS.Serivce.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
});

builder.Services.AddTransient<ISQLServerHandler, SQLServerHandler>();
//sql User server repository
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();

//sql mentor service repository
builder.Services.AddTransient<IMentorRepository, MentorRepository>();
builder.Services.AddTransient<IMentorService,MentorService>();

// sql Batch service repository
builder.Services.AddTransient<IBatchRepository,BatchRepository>();
builder.Services.AddTransient<IBatchService,BatchService>();

//sql year service repository
builder.Services.AddTransient<IYearRepository,YearRepository>();

builder.Services.AddTransient<IYearService, YearService>();

//sql project service repository
builder.Services.AddTransient<IProjectRepository,ProjectRepository>();
builder.Services.AddTransient<IProjectService,ProjectService>();

//sql projectAllotment service repository
builder.Services.AddTransient<IPrjAllotmentRepository, PrjAllotmentRepository>();
builder.Services.AddTransient<IPrjAllotmentService,PrjAllotmentService>();

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
app.UseCors("AllowAll");
app.Run();
