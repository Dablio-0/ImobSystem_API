
using System.Security.Policy;

namespace ImobSystem_API.Models
{
    public class House
    {
        #region Properties
        public uint Id { get; set; }
        public string Address { get; set; }
        public uint Rooms { get; set; }
        public string Type { get; set; }
        public string ZipCode { get; set; }
        #endregion

        #region Section of Relationships

        // House - Agreement (One to One)
        public Agreement Agreement;

        // House - Owner (Many to Many)
        public ICollection<Owner> Owners;

        // Get the user that manipulated the agreement
        public uint UserId { get; set; }
        public User User { get; set; }
        #endregion

        #region Constructors
        public House()
        {
            this.Id = 0;
            this.Address = this.Type = this.ZipCode = "";
            this.Rooms = 0;
            this.Agreement = new Agreement();
            this.Owners = new List<Owner>();
            this.User = new User();
        }

        public House(string address, uint rooms, string type, string zipCode)
        {
            this.Address = address;
            this.Rooms = rooms;
            this.Type = type;
            this.ZipCode = zipCode;
            this.Agreement = new Agreement();
            this.Owners = new List<Owner>();
            this.User = new User();
        }
        #endregion
    }
}