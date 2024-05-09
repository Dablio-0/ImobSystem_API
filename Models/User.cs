namespace ImobSystem_API.Models
{
    public class User
    {
        #region Properties
        private uint id;
        private string name;
        private string email;
        private string password;
        private DateOnly age;
        private DateTime createdAt;
        private DateTime updatedAt;
        #endregion

        #region Constructor
        public User(string name, string email, string password, DateOnly age)
        {
            Name = name;
            Email = email;
            Password = password;
            Age = age;
            CreatedAt = DateTime.Now;
        }
        #endregion

        #region Get & Set of Properties
        public uint getId()
        {
            return this.id;
        }

        public void setId(uint id)
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public DateOnly getAge()
        {
            return this.age;
        }

        public void setAge(DateOnly age)
        {
            this.age = age;
        }
        #endregion

        #region Get the date and time when the user was created
        public DateTime getCreatedAt()
        {
            return this.createdAt;
        }

        public void setCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
        }

        public DateTime GetUpdatedAt()
        {
            return this.updatedAt;
        }

        public void SetUpdatedAt(DateTime updatedAt)
        {
            updatedAt = updatedAt;
        }
        #endregion
    }
}
