namespace ImobSystem_API.Models
{
    public class HouseOwner
    {
        public uint HouseId { get; set; }
        public House House { get; set; }

        public uint OwnerId { get; set; }
        public Owner Owner { get; set; }

        public HouseOwner()
        {
            this.HouseId = this.OwnerId = 0;
            House = new House();
            Owner = new Owner();
        }

        public HouseOwner(uint houseId, uint ownerId)
        {
            HouseId = houseId;
            OwnerId = ownerId;
            House = new House();
            Owner = new Owner();

        }
    }
}
