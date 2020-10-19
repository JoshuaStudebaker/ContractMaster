using System.ComponentModel.DataAnnotations;

namespace ContractMaster.Models
{
  public class Job
  {
    public int Id { get; set; }
    public string StreetAddress { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    [MinLength(2)]
    [MaxLength(2)]
    public string State { get; set; }
    [Required]
    [MinLength(5)]
    [MaxLength(5)]
    public int ZipCode { get; set; }
    [Required]
    public string Description { get; set; }
    public string ContactName { get; set; }
    [Required]
    [MinLength(10)]
    public string ContactPhone { get; set; }
    public string ContactEmail { get; set; }

  }
}