namespace ImobSystem_API.Models
{
    public class User
    {
        #region Properties
        private uint Id;
        private string Name;
        private string Email;
        private string Password;
        private DateOnly Age;
        private DateTime CreatedAt;
        private DateTime UpdatedAt;
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

        public string GetPassword()
        {
            return this.Password;
        }

        public void SetPassword(string password)
        {
            Password = password;
        }

        public DateOnly GetAge()
        {
            return this.Age;
        }

        public void SetAge(DateOnly age)
        {
            Age = age;
        }
        #endregion

        #region Get the date and time when the user was created
        public DateTime GetCreatedAt()
        {
            return this.CreatedAt;
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
    }
}
