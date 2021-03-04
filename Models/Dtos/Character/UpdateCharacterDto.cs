namespace RolePlayingGame.Models.Dtos.Character
{
    public class UpdateCharacterDto
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Sam";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set;} = 10;
        public RpgMode Mode { get; set; } = RpgMode.Knight;
    }
}