﻿using ParksLookup.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ParksLookup
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ParksLookupContext>(opt =>
        opt.UseMySql(Configuration.GetConnectionString("DefaultConnection")));

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

			services.AddCors(o => o.AddPolicy 
			("MyPolicy", builder => {
				builder.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader()
					.AllowCredentials();
			}));

			services.AddApiVersioning(config =>
			{
				config.DefaultApiVersion = new ApiVersion(1, 0);
				config.AssumeDefaultVersionWhenUnspecified = true;
				config.ReportApiVersions = true;
			});

			services.AddSwaggerDocument();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

			app.UseOpenApi();
    	app.UseSwaggerUi3();

			// app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}
