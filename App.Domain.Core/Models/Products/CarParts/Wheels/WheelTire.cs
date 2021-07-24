namespace App.Domain.Core
{
    public class WheelTire : CarPart, IPartnerProduct
    {
        public float MaxTirePressure { get; set; }
        public TireSeason Season { get; set; } 
        public Partner Manufacturer { get; set; }
    }
}
