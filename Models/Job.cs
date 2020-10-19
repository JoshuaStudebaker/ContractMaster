using System.ComponentModel.DataAnnotations;

namespace ContractMaster.Models
{
  public class Job
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
    public string Description { get; set; }
    public string ContactName { get; set; }
    public string ContactPhone { get; set; }

  }
}