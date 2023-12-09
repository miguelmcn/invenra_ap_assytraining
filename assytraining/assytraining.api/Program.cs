using assytraining.api;
using assytraining.api.Configuration;
using assytraining.api.Controllers;
using assytraining.application.Domain;
using assytraining.infrastructure.Repositories.DataModel;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<InvenRAMockService>();

builder.Services.AddRazorPages(
    options =>
    {
        options.Conventions.AddPageRoute("/ActivityConfiguration", "/configuracao-atividade.html");
        options.Conventions.AddPageRoute("/ActivityConfiguration", "/configuracao-atividade");
    });

builder.Services.AddSingleton<ILogger<InvenRAController>, Logger<InvenRAController>>();

APConfigurationSetup.SetupAPConfiguration(builder.Services);
AnalyticsConfigurationSetup.SetupAnalyticsConfiguration(builder.Services);
AnalyticsSetup.SetupAnalyticsConfiguration(builder.Services);
ActivityConfigurationSetup.SetupActivityConfiguration(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{    
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.MapRazorPages();

app.Run();
