using CattleManager.Infra.Context;
using CattleManager.Infra.Repositories.TerrainRepository;
using CattleManager.Infra.Repositories.UserRepository;
using CattleManager.Infra.Repositories.CattleRepository;
using Microsoft.OpenApi.Models;

namespace CattleManager.Web;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(Program).Assembly);
        services.AddControllers();

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ITerrainRepository, TerrainRepository>();
        services.AddScoped<ICattleRepository, CattleRepository>();

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ITerrainService, TerrainService>();
        services.AddScoped<ICattleService, CattleService>();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "CattleManager.WebApi", Version = "v1" });
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CattleManager.WebApi v1"));
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
