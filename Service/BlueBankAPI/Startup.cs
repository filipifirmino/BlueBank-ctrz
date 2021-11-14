using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Data.Repositorys;
using BlueBank.Domain.Data;
using Data.Repositorys;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using BlueBank.Infra.Data.Repositorys;
using FluentValidation.AspNetCore;
using BlueBank.Domain.Core.Validator;
using BlueBank.Domain.Core.Requestes;

namespace BlueBankAPI
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

            services.AddControllers()
                .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<AddClientRequestValidator>())
                .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<UpdateClientRequestValidator>())
                .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<DepositTransactionValidator>())
                .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<TransferTransactionValidator>())
                .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<WithdrawTransactionValidator>());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BlueBankAPI", Version = "v1" });
            });
            var connection = Configuration.GetConnectionString("BankDb");
            services.AddDbContext<BankContext>(options => options.UseSqlServer(connection, b => b.MigrationsAssembly("BlueBankAPI")));
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IHistoryRepository, HistoryRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BlueBankAPI v1"));
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
