using System.ComponentModel.DataAnnotations;

namespace HelloWebApi.ClientModels.Movies

{
    public class MovieRequestModel
    {
        [Required] 
        public int Id { get; set; }

        [Required] 
        public string Name { get; set; }

        [Required] 
        public string Year { get; set; }

        [Required] 
        public string Country { get; set; }

        [Required] 
        public string Director { get; set; }
    }
}
