using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<Client> Clients { get; set; }

    public HairSalonContext(DbContextOptions opitons) : base(options) { }
  }
}