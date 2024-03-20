namespace GameZon.Models
{
    public class Device: BaseEntity
    {
        [MaxLength(length: 2500)]
        public string Icon { get; set; } = string.Empty;
    }
}
