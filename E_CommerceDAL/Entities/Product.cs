namespace E_CommerceDAL.Entities
{
    public class Product : CommonEntity // Inherits from CommonEntity (Id, Name, Description)
    {
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public ProductColor ProductColor { get; set; }

        // Nav Property 
        public Category Category { get; set; } = null!;

        // Foreign Key
        public int CategoryId { get; set; }
    }
}
