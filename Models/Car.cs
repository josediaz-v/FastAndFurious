using System.ComponentModel.DataAnnotations;

public class Car
{
    [Key]  // Specify that this property is the primary key
    [Display(Name = "VIN Number")]
    public string vin { get; set; }  // Keep vin as the primary key
    public string plate { get; set; }
    public string make { get; set; }
    public string model { get; set; }
    public string? @class { get; set; }
    public int? year { get; set; }
    public string transmission { get; set; }
    public string? drive { get; set; }
    public int? cylinders { get; set; }
}
