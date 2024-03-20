namespace GameZon.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        [MaxLength(length: 2500)]
        public string Name { get; set; } = string.Empty;
    }
}
