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
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Section of Relationships 
        // Owner - House (Many to Many)
        public ICollection<House> Houses;

        // Get the user that manipulated the agreement
        public uint UserId { get; set; }
        public User User { get; set; }
        #endregion

        #region Constructor
        public Owner()
        {
            this.Name = this.Email = this.Phone = this.Cpf = "";
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Houses = new List<House>();
            this.User = new User();
        }

        public Owner(string name, string email, string phone, string cpf)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Cpf = cpf;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Houses = new List<House>();
            this.User = new User();
        }
        #endregion
    }
}
