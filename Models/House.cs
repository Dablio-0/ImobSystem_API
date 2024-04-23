using System.CodeDom;

namespace ImobSystem_API.Models
{
    public class House
    {
        private uint Id;
        private string Address;
        public string ZipCode;

        public House(uint id, string address, string zipCode)
        {
            Id = id;
            Address = address;
            ZipCode = zipCode;
        }

        public uint GetId()
        {
            return Id;
        }

        public string GetAddress()
        {
            return Address;
        }

        public void SetAddress(string address)
        {
            Address = address;
        }

        public string GetZipCode()
        {
            return ZipCode;
        }

        public void SetZipCode(string zipCode)
        {
            ZipCode = zipCode;
        }
    }
}