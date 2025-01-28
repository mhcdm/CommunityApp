using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class City {
    [Key]
    public int CityId { get; set; }
    public string? CityName { get; set; }
    public int Population { get; set; }
    // [ForeignKey("Province")]
    public Province? Province { get; set; }
}