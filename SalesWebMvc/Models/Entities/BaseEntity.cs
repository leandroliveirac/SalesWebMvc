namespace SalesWebMvc.Models.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        protected BaseEntity()
        {
        }

        protected BaseEntity(int id)
        {
            Id = id;
        }
    }
}
