namespace ImobSystem_API.Models
{
    public class Owner
    {
        #region Properties
        public uint id;
        public string name;
        public DateOnly age;
        public string email;
        public string phone;
        public string cpf;
        public DateTime createdAt;
        public DateTime updatedAt;
        #endregion

        #region Section of Relationships 
        // Owner - House (Many to Many)
        public ICollection<House> Houses;
        #endregion

        #region Constructor
        public Owner()
        {
            this.id = 0;
            this.name = this.email = this.phone = this.cpf = "";
            this.age = new DateOnly();
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
            Houses = new List<House>();
        }

        public Owner(string name, string email, string phone, string cpf)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.cpf = cpf;
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
            Houses = new List<House>();
        }
        #endregion

        #region Get & Set of Properties
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public DateOnly getAge()
        {
            return this.age;
        }

        public void setAge(DateOnly age)
        {
            this.age = age;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPhone()
        {
            return this.phone;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public string getCPF()
        {
            return this.cpf;
        }

        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }

        public DateTime getCreatedAt()
        {
            return this.createdAt;
        }

        public void setCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
        }

        public DateTime getUpdatedAt()
        {
            return this.updatedAt;
        }

        public void setUpdatedAt(DateTime updatedAt)
        {
            this.updatedAt = updatedAt;
        }
        #endregion        
    }
}
