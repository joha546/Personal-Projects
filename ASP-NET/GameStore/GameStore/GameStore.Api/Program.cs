using GameStore.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
    new (1,
    "Street Fighter 2",
    "Fighting",
    19.99M,
    new DateOnly(1992, 7, 15)),

    new (2,
    "Final Fantasy 14",
    "RolePlaying",
    59.99M,
    new DateOnly(2010, 9, 30)
    ),
    
    new (3,
    "FIFA 23",
    "Sports",
    69.9M,
    new DateOnly(2022, 9, 27)
    )
];

app.MapGet("games", () => games);   // Implemented Minimal Api.
app.MapGet("/", () => "Hello World!");   // Handler

app.Run();

// from line 2 to 6 is configurations line.
