namespace ImobSystem_API.Models
{
    public class HouseOwner
    {
        public uint HouseId { get; set; }
        public House House { get; set; }

        public uint OwnerId { get; set; }
        public Owner Owner { get; set; }

        public uint UserId { get; set; }
        public User User { get; set; }

        public HouseOwner()
        {
            this.House = new House();
            this.Owner = new Owner();
            this.User = new User();
        }

        public HouseOwner(uint houseId, uint ownerId, uint userId)
        {
            this.HouseId = houseId;
            this.OwnerId = ownerId;
            this.UserId = userId;
            this.House = new House();
            this.Owner = new Owner();
            this.User = new User();

        }
    }
}
