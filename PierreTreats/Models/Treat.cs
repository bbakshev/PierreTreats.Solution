using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreTreats.Models
{
    public class Treat
    {
      public int TreatId { get; set; }
      [Required(ErrorMessage = "Please enter a name for this treat")]
      public string Name { get; set; }
      [Required(ErrorMessage = "Please enter a description for this treat")]
      public string Description { get; set; }
      public int Rating { get; set; }
      public List<TreatFlavor> JoinEntities { get; set; }
      public ApplicationUser User { get; set; }
    }
}