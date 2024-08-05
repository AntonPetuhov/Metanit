using DotNetProj;

/* Simple API */
// начальные данные
List<Analyzer> analyzerList = new List<Analyzer>()
{
    new Analyzer(Guid.NewGuid().ToString(), "Sysmex XN-550", "172.18.0.1", 8001),
    new Analyzer(Guid.NewGuid().ToString(), "Exias", "172.18.0.2", 8002),
    new Analyzer(Guid.NewGuid().ToString(), "Mindray BC620", "172.18.0.3", 8003),
};

analyzerList.Add(new Analyzer(Guid.NewGuid().ToString(), "Alinity i", "172.18.0.4", 8004));

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) =>
{
    var response = context.Response;
    var request = context.Request;
    var path = context.Request.Path;

    if (path == "/api/analyzers/" && request.Method == "GET")
    {

    }

    if (path == "/api/") { }

});

app.MapGet("/", () => "Hello World!");



/* Получаем адрес, по которому обращается клиент
app.Run(async (context) => await context.Response.WriteAsync($"Path: {context.Request.Path}"));
app.Run(async (context) => await context.Response.WriteAsJsonAsync($"Path: {context.Request.Path}"));
*/

// Получаем адрес, по которому обращается клиент
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

// получение всех анализаторов
async Task GetAllAnalyzers()
{

}