using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Sistema_escolar.Business.Alunos;
using Sistema_escolar.Business.DisciplinasAlunos;
using Sistema_escolar.Data;
using Sistema_escolar.Map;
using Sistema_escolar.Repository.Alunos;
using Sistema_escolar.Repository.DisciplinasAlunos;

namespace Sistema_escolar
{
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
            services.AddDbContext<BancoContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DataBase")));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sistema_escolar", Version = "v1" });
            });

            services.AddScoped<IRegras, Regras>();
            services.AddScoped<IAcessobancoAlunos, AcessoBancoAlunos>();
            services.AddScoped<IRegrasDisciplinas, RegrasDisciplinas>();
            services.AddScoped<IAcessobancoDisciplinas, AcessoBancoDisciplinas>();

            IMapper mapper = RelacionamentoMap.mapeador().CreateMapper();

            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sistema_escolar v1"));
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
}
