using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CsharpCRUD.Models;

public class Student {
    [Key]
    [DisplayName("Id")]

public int Id {get; set;}

    [Required(ErrorMessage ="Provide your name")]
    [StringLength(32, ErrorMessage ="Your name must be a maximum of 32 characters")]
    [MinLength(5 ,ErrorMessage ="Your name must be at least 5 characters long")]
    [DisplayName("Full name")]

    public string Email {get; set;} = string.Empty;

    public List<Premium> Premiuns {get; set; } = new();
}