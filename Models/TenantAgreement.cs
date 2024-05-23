using System.Security.Cryptography.X509Certificates;

namespace ImobSystem_API.Models
{
    public class TenantAgreement
    {
        public uint TenantId { get; set; }
        public Tenant Tenant { get; set; }

        public uint HouseId { get; set; }
        public House House { get; set; }

        public TenantAgreement()
        {
            this.TenantId = this.HouseId = 0;
            Tenant = new Tenant();
            House = new House();
        }

        public TenantAgreement(uint tenantId, uint houseId)
        {
            TenantId = tenantId;
            HouseId = houseId;
            Tenant = new Tenant();
            House = new House();
        }
    }
}
