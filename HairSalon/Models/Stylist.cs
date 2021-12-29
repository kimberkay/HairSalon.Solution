using Systems.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId{ get; set; }
    public string StylistFirstName { get; set;}
    public string StylistLastName { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}