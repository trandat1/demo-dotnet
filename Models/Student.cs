using System.ComponentModel.DataAnnotations;

public class Student
{
    private Guid id = Guid.NewGuid();
    public Guid Id
    {
        get => id;
        set 
        {
            id = value;
        }
    }

    [Required(ErrorMessage = "Please enter the First name...")]
    public string? FirstName{get;set;}
    [Required(ErrorMessage = "Please enter the Last name...")]
    public string? LastName{get;set;}

    public string? FullName
    {
        get => $"{FirstName} {LastName}";
    }
    public string? Gender{get;set;}
    public string? Email{get;set;}
    public string? Address{get;set;}
    public DateTime? DateOfBirth{get;set;}

}