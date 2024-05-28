using System.Security.Cryptography.X509Certificates;

namespace ImobSystem_API.Models
{
    public class TenantAgreement
    {
        public uint TenantId { get; set; }
        public Tenant Tenant { get; set; }

        public uint HouseId { get; set; }
        public House House { get; set; }

        public uint UserId { get; set; }
        public User User { get; set; }

        public TenantAgreement()
        {
            this.Tenant = new Tenant();
            this.House = new House();
            this.User = new User();
        }

        public TenantAgreement(uint tenantId, uint houseId, uint userId)
        {
            this.TenantId = tenantId;
            this.HouseId = houseId;
            this.UserId = userId;
            this.Tenant = new Tenant();
            this.House = new House();
            this.User = new User();
        }
    }
}
