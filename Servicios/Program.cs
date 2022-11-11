using BusinessLogic.Implementacion;
using BusinessLogic.Interfaces;
using DataAccesLayer.Implementacion;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddDbContext<SolutionContext>();
// For Identity
builder.Services.AddIdentity<Users, IdentityRole>()
    .AddEntityFrameworkStores<SolutionContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SolutionContext>();

// Adding Authentication
string? JWT_SECRET = Environment.GetEnvironmentVariable("JWT_SECRET");
if (string.IsNullOrEmpty(JWT_SECRET))
    JWT_SECRET = configuration["JWT:Secret"];
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer
.AddJwtBearer(options =>
 {
     options.SaveToken = true;
     options.RequireHttpsMetadata = false;
     options.TokenValidationParameters = new TokenValidationParameters()
     {
         ValidateIssuer = false,
         ValidateAudience = false,
         //ValidAudience = configuration["JWT:ValidAudience"],
         //ValidIssuer = configuration["JWT:ValidIssuer"],
         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
     };
 });

builder.Services.Configure<DataProtectionTokenProviderOptions>(options =>
{
    // Reset token valid for 2 hours
    options.TokenLifespan = TimeSpan.FromHours(2);
});

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "Web API - V1",
            Version = "v1"
        }
     );

    //var filePath = Path.Combine(AppContext.BaseDirectory, "WebAPI.xml");
    //c.IncludeXmlComments(filePath);

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
        {
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
        }
    },
        new string[] {}
    }});
});






/********************************************************************************************************/
/** Add Dependencies                                                                                   **/
/********************************************************************************************************/
builder.Services.AddTransient<I_ManejadorTorneo, ManejadorTorneo>();
builder.Services.AddTransient<IB_Torneo, B_Torneo>();

builder.Services.AddTransient<I_ManejadorUsuario, ManejadorUsuario>();
builder.Services.AddTransient<IB_Usuario, B_Usuario>();

builder.Services.AddTransient<I_ManejadorPenca, ManejadorPenca>();
builder.Services.AddTransient<IB_Penca, B_Penca>();

builder.Services.AddTransient<I_ManejadorEvento, ManejadorEvento>();
builder.Services.AddTransient<IB_Evento, B_Evento>();

builder.Services.AddTransient<I_ManejadorPremio, ManejadorPremio>();
builder.Services.AddTransient<IB_Premio, B_Premio>();

builder.Services.AddTransient<I_ManejadorSubscripcion, ManejadorSubscripcion>();
builder.Services.AddTransient<IB_Subscripcion, B_Subscripcion>();

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

app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.Run();

