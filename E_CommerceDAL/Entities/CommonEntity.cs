namespace E_CommerceDAL.Entities
{
    public abstract class CommonEntity
    {
        public int Id { get; set; } // Primary key
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

    }
}
