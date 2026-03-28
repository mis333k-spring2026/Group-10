using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Team_10_Final_Project.Models
{

public class AppUser : IdentityUser
{
    // Customer info
   
    [Required]
    [Display(Name = "First Name")]
    public String FirstName { get; set; }
    [Required]
    [Display(Name = "Last Name")]
    public String LastName { get; set; }
    [Required]
    [Display(Name = "Address")]
    public String Address { get; set; }
   
    [Required]
    [Display(Name = "City")]
    public String City { get; set; }
    [Required]
    [Display(Name = "State")]
    public String State { get; set; }
   
   
    [Required]  
    [Display(Name = "Zip Code")]
    public String ZipCode { get; set; }

    // Status (for disable/enable)
    public Boolean Status { get; set; } = true;

    // Navigation properties, y'all can uncomment this later when yall make the models
    //public List<Order> Orders { get; set; }
    //public List<Review> Reviews { get; set; }
}

}