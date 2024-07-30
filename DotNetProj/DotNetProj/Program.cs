using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

/* ѕолучаем адрес, по которому обращаетс€ клиент
app.Run(async (context) => await context.Response.WriteAsync($"Path: {context.Request.Path}"));
app.Run(async (context) => await context.Response.WriteAsJsonAsync($"Path: {context.Request.Path}"));
*/

// ѕолучаем адрес, по которому обращаетс€ клиент
app.Run(async (context) =>
{
    var path = context.Request.Path;
    var response = context.Response;

    if (path == "/analyzers")
        await response.WriteAsync("Analyzers list");
    else if (path == "/welcome")
        await response.WriteAsync($"Welcome page");
    else
        await response.WriteAsync($"Path: {path}");
});

//app.UseWelcomePage();

app.Run();
