using CLEAN_APPLICATION;
using CLEAN_INFRASTRUCTURE;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // 
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

