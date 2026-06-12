namespace Core.Entities;

public class Product : BaseEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Model { get; set; }
    public required string Description { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime UpdatedOn { get; set; }
}