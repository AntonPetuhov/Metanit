using DotNetProj;
using Database;
using System.Net.Http.Headers;

/* Simple API */

//var analyzerdb = new AnalyzerDB();
AnalyzerDB? analyzerdb = new AnalyzerDB();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) =>
{
    var response = context.Response;
    var request = context.Request;
    var path = context.Request.Path;

    List<Analyzer> analyzerList = analyzerdb.GetAllAnalyzers();

    if (path == "/api/analyzers/" && request.Method == "GET")
    {
        await response.WriteAsJsonAsync(analyzerList);
    }
    else if(path == "/api/analyzers/add" && request.Method == "POST")
    {
        analyzerdb.AddAnalyzerToList();
        await response.WriteAsJsonAsync("New analyzer in list");
        await response.WriteAsJsonAsync(analyzerList);
    }
    else if (path == "/api/") 
    {
        await response.WriteAsync("Analyzers API");
    }
    else
    {
        await response.WriteAsync($"Welcome page");
    }

});

app.MapGet("/", () => "Hello World!");



/* ѕолучаем адрес, по которому обращаетс€ клиент
app.Run(async (context) => await context.Response.WriteAsync($"Path: {context.Request.Path}"));
app.Run(async (context) => await context.Response.WriteAsJsonAsync($"Path: {context.Request.Path}"));
*/

// ѕолучаем адрес, по которому обращаетс€ клиент
/*
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
*/

//app.UseWelcomePage();

app.Run();
