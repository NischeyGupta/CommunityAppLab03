using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Province
{
    [Key]
    // [Required]
    [Display(Name = "Province Code")]
    public string? ProvinceCode { get; set; }

    // [Required]
    [Display(Name = "Province")]
    public string? ProvinceName { get; set; }

    public ICollection<City>? Cities { get; set; }
}
