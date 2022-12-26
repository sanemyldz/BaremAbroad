using BaremAbroad.Core.Repositories;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository;
using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.Repositories;
using BaremAbroad.Service.Mapping;
using BaremAbroad.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IBlogArticleRepository, BlogArticleRepository>();
builder.Services.AddScoped<IBlogArticleService, BlogArticleService>();
builder.Services.AddScoped<IFaqService, FaqService>();
builder.Services.AddScoped<IFollowService, FollowService>();
builder.Services.AddScoped<ISchoolService, SchoolService>();
builder.Services.AddScoped<IUserCommentLogService, UserCommentLogService>();
builder.Services.AddScoped<IUserCommentService, UserCommentService>();
builder.Services.AddScoped<IUserPasswordService, UserPasswordService>();
builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddAutoMapper(typeof(MapProfile));


//TODO: new scopes needed

builder.Services.AddDbContext<DataContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DbConnect")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
