using AngularProject.DB.Enums;

namespace AngularProject.DB.Entities
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }    
        public string? Description { get; set; } 
        public Category? Category { get; set; }   
        public object? Img { get; set; } 
    }
}
