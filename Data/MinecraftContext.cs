using Microsoft.EntityFrameworkCore;
using GuideAPI.Data.Entities;
 
namespace GuideAPI.Data;
 
public class MinecraftContext : DbContext
{
    public MinecraftContext(DbContextOptions<MinecraftContext> context) : base(context)
    {
    }
    public DbSet<Scroller> Scroller { get; set; }
}