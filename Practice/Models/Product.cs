namespace Practice.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image {  get; set; }

        public Product(int  id, string? name, string? description, string? image)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
        }
    }

}
