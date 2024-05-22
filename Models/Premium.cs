using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CsharpCRUD.Models;

public class Premium
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter premium title")]
    [StringLength(32, ErrorMessage = "Your title must be a maximum of 32 characters")]
    [MinLength(5, ErrorMessage = "Your title must be at least 5 characters long")]
    [DisplayName("Title")]

    public string Title { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    [DisplayName("initiation")]
    //[GreaterThanToday]
    public DateTime StartDate { get; set; }


    [DataType(DataType.DateTime)]
    [DisplayName("Termination")]
    public DateTime EndDate { get; set; }

    [DisplayName("Student")]
    [Required(ErrorMessage ="Invalid Student")]
    public int StudentId { get; set; }

    public Student? Student { get; set; }

    public List<Premium> Premiums { get; set; } = new();
}
