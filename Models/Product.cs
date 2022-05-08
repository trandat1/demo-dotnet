using System.ComponentModel.DataAnnotations;

public class Product
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

    [Required(ErrorMessage = "Please enter the name...")]
    public string? Name{get;set;}
    [Required(ErrorMessage = "Please enter the description...")]
    public string? Description{get;set;}

    public string? price{get;set;}
    
    public string? Image{get;set;}
   
    public int status=1;
    

}