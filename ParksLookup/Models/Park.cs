using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    [Required]
    [StringLength(100)]
    public string Agency { get; set; }
    [Required]
    [StringLength(100)]
    public string State { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public bool Campsites { get; set; }
    public string ImgUrl { get; set; }
  }
}