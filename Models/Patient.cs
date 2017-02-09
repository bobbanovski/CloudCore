using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Patient
    {
      public int Id { get; set; }
      
      [Required]
      public string Name { get; set; }
      public ICollection<Medication> Medications { get; private set; }

      public Address Address { get; private set; }

      public Patient()
      {
        Medications = new List<Medication>();
        Address = new Address(); 
      }
    }
}
