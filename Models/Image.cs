using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Image
    {

        [Key]
        public string Id { get; set; }

        
        public string Description { get; set; }

        //This must be Required, but for now let's set it like this. 
        public string ImageUrl { get; set; }

        //The foreign-key link between Image and ApplicationUser. 
        //One-to-Many relationship. 
        public string UserId { get; set; }


        //Navigation Properties: 
        public ApplicationUser User { get; set; }


    }
}
