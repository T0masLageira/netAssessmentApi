using Microsoft.EntityFrameworkCore;
using tomasLageiraDatabase.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ClaimsDb>(opt => opt.UseInMemoryDatabase("ClaimsList"));
builder.Services.AddDbContext<OwnersDb>(opt => opt.UseInMemoryDatabase("OwnersList"));
builder.Services.AddDbContext<VehiclesDb>(opt => opt.UseInMemoryDatabase("VehiclesList"));
var app = builder.Build();

// Add services to the container.
//builder.Services.AddControllersWithViews();


app.MapPost("/add-user", async (Owners owner, OwnersDb db) =>
{
    db.Owner.Add(owner);
    await db.SaveChangesAsync();

    return Results.Created($"/ownerItems/{owner.Id}", owner);
});


app.MapPost("/add-claim", async (Claims claim, ClaimsDb db) =>
{
    db.Claim.Add(claim);
    await db.SaveChangesAsync();

    return Results.Created($"/claimItems/{claim.Id}", claim);
});


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
/*
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
*/
app.Run();
