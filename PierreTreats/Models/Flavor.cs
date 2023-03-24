using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreTreats.Models
{
    public class Flavor
    {
      public int FlavorId { get; set; }
      [Required(ErrorMessage = "Please enter a name for this flavor")]
      public string Name { get; set; }
      public List<TreatFlavor> JoinEntities { get; set; }
      public ApplicationUser User { get; set; }
    }
}