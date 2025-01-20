using Innova.Core.Models;
using Innova.Core.Services;
using Innova.Repository.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Swagger Configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB Context Configuration
builder.Services.AddDbContext<AppDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Register Services
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

// Redis Configuration
builder.Services.AddStackExchangeRedisCache(options =>
{
	options.Configuration = builder.Configuration.GetConnectionString("RedisConnection");
	options.InstanceName = "Innova_";
});

#region Identity Configuration
builder.Services.AddIdentity<User, IdentityRole>()
	.AddEntityFrameworkStores<AppDbContext>()
	.AddDefaultTokenProviders();
#endregion

// JWT Authentication Configuration
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
	.AddJwtBearer(options =>
	{
		options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
		{
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidateLifetime = true,
			ValidIssuer = builder.Configuration["Jwt:Issuer"],  //  „ «· √ﬂœ „‰ √‰Â« „ÊÃÊœ… ›Ì appsettings.json
			ValidAudience = builder.Configuration["Jwt:Audience"], //  „ «· √ﬂœ „‰ √‰Â« „ÊÃÊœ… ›Ì appsettings.json
			IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(
				System.Text.Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]) //  „ «· √ﬂœ „‰ √‰ «·„› «Õ „ÊÃÊœ ›Ì appsettings.json
			)
		};
	});

var app = builder.Build();

// Database Migration and Seeding
#region Migration
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var _dbContext = services.GetRequiredService<AppDbContext>();
var loggerFactory = services.GetRequiredService<ILoggerFactory>();

try
{
	await _dbContext.Database.MigrateAsync();
	var userManager = services.GetRequiredService<UserManager<User>>();
}
catch (Exception ex)
{
	var logger = loggerFactory.CreateLogger<Program>();
	logger.LogError(ex, "An error occurred while applying the migration");
}
#endregion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Add Authentication and Authorization Middleware
app.UseAuthentication();  // Add Authentication Middleware
app.UseAuthorization();

app.MapControllers();

app.Run();


