namespace ImobSystem_API.Models
{
    public class Tenant
    {
        #region Properties
        public uint Id { get; set; }
        public string Name { get; set; }
        public DateOnly Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region  Section of Relationships
        //Tenant - Agreement (Many to Many)
        public ICollection<Agreement> Agreements;

        // Get the user that manipulated the agreement
        public uint UserId { get; set; }
        public User User { get; set; }
        #endregion

        #region Constructor
        public Tenant()
        {
            this.Id = 0;
            this.Name = this.Email = this.Phone = this.Cpf = "";
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Agreements = new List<Agreement>();
            this.User = new User();
        }

        public Tenant(string name, string email, string phone, string cpf)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Cpf = cpf;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Agreements = new List<Agreement>();
            this.User = new User();
        }
        #endregion
    }
}
