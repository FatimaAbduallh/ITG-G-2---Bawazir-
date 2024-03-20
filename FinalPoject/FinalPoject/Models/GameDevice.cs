namespace GameZon.Models
{
    public class GameDevice
    {
        public int IdGame { get; set; }
        public Game Game { get; set; } = default!;

        public int IdDevice { get; set; }
        public Device Device { get; set; } = default!;


    }
}
