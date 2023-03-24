using Microsoft.AspNetCore.Mvc;
using Vero.Config;
using Vero.Repositories;
using Vero.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));
builder.Services.AddSingleton<ITaxCardRepository, TaxCardRepository>();
builder.Services.AddSingleton<ITaxCardService, TaxCardService>();

var app = builder.Build();

app.MapGet("/", () => "App is running!");
app.MapGet("/tax-cards/{id:guid}", (Guid id, [FromServices] ITaxCardService repository) =>
{
    var taxCard = repository.Load(id);
    return Results.Ok(taxCard);
});
app.MapGet("/tax-cards", ([FromServices] ITaxCardService repository) =>
{
    var taxCards = repository.LoadAll();
    return Results.Ok(taxCards);
});
app.MapPost("/users/{userId:guid}/tax-cards", (Guid userId, [FromBody] Vero.Api.Codegen.Model.PostUsersUserIdTaxCardsTaxCardIdRequest request, [FromServices] ITaxCardService repository) =>
{
    var result = repository.Create(userId, request.TaxCard);
    return Results.Ok(result);
});

app.Run("http://*:5081");
