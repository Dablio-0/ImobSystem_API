
namespace ImobSystem_API.Models
{
    public class House
    {
        #region Properties
        public uint id;
        private string address;
        private uint rooms;
        private string type;
        private string zipCode;
        #endregion

        #region Section of Relationships

        // House - Agreement (One to One)
        public Agreement Agreement;

        // House - Owner (Many to Many)
        public ICollection<Owner> Owners = new List<Owner>();
        #endregion

        #region Constructor
        public House(string address, uint rooms, string type, string zipCode)
        {
            this.address = address;
            this.rooms = rooms;
            this.type = type;
            this.zipCode = zipCode;
        }
        #endregion

        #region Get & Set of Properties
        public string getAddress()
        {
            return this.address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public uint getRooms()
        {
            return this.rooms;
        }

        public void setRooms(uint rooms)
        {
            this.rooms = rooms;
        }

        public string getType()
        {
            return this.type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public string getZipCode()
        {
            return this.zipCode;
        }

        public void setZipCode(string zipCode)
        {
            this.zipCode = zipCode;
        }
        #endregion
    }
}