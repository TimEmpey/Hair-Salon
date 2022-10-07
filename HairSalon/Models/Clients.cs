namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Regular { get; set; } 
    public string Last { get; set; } 
    public int Total { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}