var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    DateTimeOffset utcTime = DateTimeOffset.UtcNow;

    // Get the IST time zone
    TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

    // Convert the UTC time to IST
    DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);

    // Format the date and time with the day of the week
    string formattedDateTime = istTime.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");

    return formattedDateTime;
});

app.Run();
