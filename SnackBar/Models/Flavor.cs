using System.Collections.Generic;
using System;

namespace SnackBar.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public string FlavorDetails { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntities { get; }
  }
}