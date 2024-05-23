using System.Numerics;
using System.Security.Cryptography;

namespace ImobSystem_API.Models
{
    public class User
    {
        #region Properties
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly Age { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Constructor
        public User()
        {
            this.Name = this.Email = this.Password = "";
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public User(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }
        #endregion
    }
}
