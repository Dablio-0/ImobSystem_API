﻿
namespace ImobSystem_API.Models
{
    public class House
    {
        #region Properties
        private uint Id;
        private string Type;
        private string Address;
        private string ZipCode;
        #endregion

        #region Section of Relationships

        // House - Agreement (One to One)
        private Agreement Agreement;

        // House - Owner (Many to Many)
        private ICollection<Owner> Owners = new List<Owner>();
        #endregion

        #region Constructor
        public House(uint id, string address, string zipCode)
        {
            Id = id;
            Address = address;
            ZipCode = zipCode;
        }
        #endregion

        #region Get & Set of Properties
        public uint GetId()
        {
            return Id;
        }

        public void SetId(uint id)
        {
            Id = id;
        }

        public string GetType()
        {
            return Type;
        }

        public void SetType(string type)
        {
            Type = type;
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
        #endregion

        #region Gets & Sets of Relationships

        // House - Agreement (One to One)
        public Agreement GetAgreement()
        {
            return Agreement;
        }

        public void SetAgreement(Agreement agreement)
        {
            Agreement = agreement;
        }

        // House - Owner (Many to Many)
        public ICollection<Owner> GetOwners()
        {
            return Owners;
        }

        public void SetOwners(ICollection<Owner> owners)
        {
            Owners = owners;
        }
        #endregion
    }
}