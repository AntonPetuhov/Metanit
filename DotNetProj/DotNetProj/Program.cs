using DotNetProj;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<string> errors = new List<string>();

app.MapGet("/", () => "Hello World!");


/* simplest API */

List <Analyzer> analyzerList = new List<Analyzer>();

analyzerList.Add(new Analyzer(Guid.NewGuid().ToString(), "Alinity i", "172.18.0.1", 8001)); 


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
