using System.ComponentModel.DataAnnotations;

namespace CapenexisLearrners.Models;

public class Movie
{
    public int Id { get; set; }
    public string? FirstName{ get; set; }
    public string?LastName { get; set; }
    public string? NationalIdentityNumber { get; set; }
    public string? Course { get; set; }
    public decimal Price { get; set; }
}
