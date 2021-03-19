using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using InventoryApp.Data;
using InventoryApp.Model;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace InventoryApp
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
            InventoryData inventoryData = new InventoryData();
            try
            {
                using (StreamReader file = File.OpenText("InventoryItem.json"))
                {
                    inventoryData.InventoryItems = new ObservableCollection<InventoryItem>( (List<InventoryItem>) JsonSerializer.Deserialize(file.ReadToEnd(),
                        returnType: typeof(List<InventoryItem>)) ?? throw new InvalidOperationException("Empty"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            services.AddControllers();
            services.AddSingleton<IDatabase, InventoryData>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "InventoryApp", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostApplicationLifetime applciationLifeTime, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "InventoryApp v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            var dbServiceProvicer = app.ApplicationServices.GetService<IDatabase>();
            applciationLifeTime.ApplicationStopping.Register(() => OnShutDown(env, dbServiceProvicer));
        }

        private void OnShutDown(IWebHostEnvironment env, IDatabase inventoryData)
        {
            File.WriteAllText("InventoryItem.json", JsonConvert.SerializeObject(inventoryData.InventoryItems));
        }
    }
}
