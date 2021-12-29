namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string ColorFormula { get; set; }

    public DateTime LastAppointment { get; set; }

    public DateTime NextAppointment { get; set; }
  }
}