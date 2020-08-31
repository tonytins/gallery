using System;
using System.Diagnostics;
using Certes;
using FluffySpoon.AspNet.EncryptWeMust;
using FluffySpoon.AspNet.EncryptWeMust.Certes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Tonytins.Api
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
            services.AddControllers();

            try
            {
                if (!Debugger.IsAttached)
                {
                    services.AddFluffySpoonLetsEncrypt(new LetsEncryptOptions
                    {
                        Email = "noreply@tonytins.xyz",
                        UseStaging = Configuration.GetValue<bool>("Staging"),
                        Domains = new[] { "api.tonytins.xyz" },
                        TimeUntilExpiryBeforeRenewal = TimeSpan.FromDays(30),
                        TimeAfterIssueDateBeforeRenewal = TimeSpan.FromDays(7),
                        CertificateSigningRequest = new CsrInfo
                        {
                            CountryName = "United States",
                            Locality = "US",
                            Organization = "Sixam",
                            OrganizationUnit = "Tonytins",
                            State = "SC"
                        }
                    });
                    services.AddFluffySpoonLetsEncryptFileCertificatePersistence();
                    services.AddFluffySpoonLetsEncryptFileChallengePersistence();
                }
            }
            catch { }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            try
            {
                if (!Debugger.IsAttached)
                    app.UseFluffySpoonLetsEncrypt();
            }
            catch { }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
