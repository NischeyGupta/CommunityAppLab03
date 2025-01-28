using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class City
{
    [Key]
    public int CityId { get; set; }

    // [Required]
    [Display(Name = "City")]
    public string? CityName { get; set; }

    public int Population { get; set; }

    // [Required]
    [ForeignKey("Province")]
    public string? ProvinceCode { get; set; }

    public Province? Province { get; set; }
}
