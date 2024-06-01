namespace ImobSystem_API.Models
{
    public class Owner
    {
        #region Properties
        public uint Id { get; set; }
        public string Name { get; set; }
        public DateOnly Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public uint IdUser { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Section of Relationships 
        // Owner - House (Many to Many)
        public ICollection<House> Houses;
        #endregion

        #region Constructor
        public Owner()
        {
            this.Id = 0;
            this.Name = this.Email = this.Phone = this.Cpf = "";
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Houses = new List<House>();
        }

        public Owner(string name, string email, string phone, string cpf)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Cpf = cpf;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Houses = new List<House>();
        }
        #endregion
    }
}
