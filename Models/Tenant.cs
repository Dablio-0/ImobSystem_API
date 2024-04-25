namespace ImobSystem_API.Models
{
    public class Tenant
    {
        #region Properties
        private uint Id;
        private string Name;
        private string Email;
        private string Phone;
        private string CPF;
        private DateTime CreatedAt;
        private DateTime UpdatedAt;
        #endregion

        #region  Section of Relationships
        //Tenant - Agreement (Many to Many)
        private ICollection<Agreement> Agreements = new List<Agreement>();
        #endregion

        #region Constructor
        public Tenant(string name, string email, string phone, string cpf)
        {
            Name = name;
            Email = email;
            Phone = phone;
            CPF = cpf;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        #endregion

        #region Get & Set of Properties
        public uint GetId()
        {
            return this.Id;
        }

        public void SetId(uint id)
        {
            Id = id;

        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public string GetPhone()
        {
            return this.Phone;
        }

        public void SetPhone(string phone)
        {
            Phone = phone;
        }

        public string GetCPF()
        {
            return this.CPF;
        }

        public void SetCPF(string cpf)
        {
            CPF = cpf;
        }

        public DateTime GetCreatedAt()
        {
            return this.CreatedAt;
        }

        public void SetCreatedAt(DateTime createdAt)
        {
            CreatedAt = createdAt;
        }

        public DateTime GetUpdatedAt()
        {
            return this.UpdatedAt;
        }

        public void SetUpdatedAt(DateTime updatedAt)
        {
            UpdatedAt = updatedAt;
        }
        #endregion

        #region Gets & Sets of Relationships
        // Tenant - House (Many to Many)
        public ICollection<Agreement> GetAgreements()
        {
            return Agreements;
        }

        public void SetAgreements(ICollection<Agreement> agreements)
        {
            Agreements = agreements;
        }
        #endregion
    }
}
