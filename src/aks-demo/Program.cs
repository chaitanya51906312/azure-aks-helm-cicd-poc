var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "AKS Helm Deployment POC V1";
});

app.MapGet("/health", () =>
{
    return Results.Ok(new
    {
        Status = "Healthy",
        Version = "1.0"
    });
});

app.Run();
