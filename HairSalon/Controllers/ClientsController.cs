using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Hired { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}