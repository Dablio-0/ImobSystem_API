
using System.Security.Policy;

namespace ImobSystem_API.Models
{
    public class House
    {
        #region Properties
        public uint id;
        public string address;
        public uint rooms;
        public string type;
        public string zipCode;
        #endregion

        #region Section of Relationships

        // House - Agreement (One to One)
        public Agreement Agreement;

        // House - Owner (Many to Many)
        public ICollection<Owner> Owners;
        #endregion

        public House()
        {
            this.id = 0;
            this.address = this.type = this.zipCode = "";
            this.rooms = 0;
            this.Agreement = new Agreement();
            this.Owners = new List<Owner>();
        }

        #region Constructor
        public House(string address, uint rooms, string type, string zipCode)
        {
            this.address = address;
            this.rooms = rooms;
            this.type = type;
            this.zipCode = zipCode;
            this.Agreement = new Agreement();
            Owners = new List<Owner>();
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