namespace E_CommerceDAL.Entities
{
    public class Category : CommonEntity // Inherits from CommonEntity (Id, Name, Description)
    {

        public Category()
        {
            Products = new HashSet<Product>(); // Initialize Category by Products
        }

        // Nav Property
        public ICollection<Product> Products { get; set; } = null!;
    }
}
