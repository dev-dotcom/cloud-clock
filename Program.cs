var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    DateTimeOffset utcTime = DateTimeOffset.UtcNow;

    TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

    DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);

    string formattedDateTime = istTime.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");

    return formattedDateTime;
});

app.Run();
