using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContractMaster.Models
{
  public class Contractor
  {
    public int Id { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    [MinLength(2)]
    [MaxLength(2)]
    public string State { get; set; }
    [MinLength(5)]
    [MaxLength(5)]
    public int ZipCode { get; set; }
    [Required]
    [MinLength(2)]
    public string Name { get; set; }
    public string ContactName { get; set; }
    [Required]
    [MinLength(10)]
    public string ContactPhone { get; set; }
    public string ContactEmail { get; set; }
    public List<string> Skills { get; set; }

  }
}