var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");   // Handler

app.Run();

// from line 2 to 6 is configurations line.
