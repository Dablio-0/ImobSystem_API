using System.Collections.Immutable;
using System.Formats.Asn1;
using System.Xml;

namespace ImobSystem_API.Models
{
    public class Agreement
    {
        #region Properties
        public uint Id { get; set; }
        public string Owner { get; set; }
        public string Tenant { get; set; }
        public string Description { get; set; }
        public string ValueAgreement { get; set; }
        public uint NumInstallments { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime InitDateAgreement { get; set; }
        public DateTime PeriodAgreement { get; set; }
        public DateTime FinalDateAgreement { get; set; }
        #endregion

        #region Section of Relationships 
        // Agreement - House (One to One)
        public uint HouseId { get; set; }
        public House House { get; set; }

        // Agreement - Tenant (Many to Many)
        public uint TenantId { get; set; }
        public ICollection<Tenant> Tenants { get; set; }

        // Get the user that manipulated the agreement
        public uint UserId { get; set; }
        public User User { get; set; }
        #endregion

        #region Constructors
        public Agreement()
        {
            this.Owner = this.Tenant = this.Description = this.ValueAgreement = "";
            this.NumInstallments = 0;
            this.Status = false;
            this.CreatedAt = DateTime.Now;
            this.UpdateAt = DateTime.Now;
            this.InitDateAgreement = Convert.ToDateTime("00:00:00");
            this.FinalDateAgreement = Convert.ToDateTime("00:00:00");
            this.PeriodAgreement = Convert.ToDateTime("00:00:00");
            this.House = new House();
            this.Tenants = new List<Tenant>();
            this.User = new User();
        }

        public Agreement(
            string owner,
            string tenant,
            string description,
            string valueAgreement,
            uint numInstallments,
            DateTime updatedAt,
            DateTime initDateAgreement,
            DateTime finalDateAgreement,
            House House
        )
        {
            this.Owner = owner;
            this.Tenant = tenant;
            this.Description = description;
            this.ValueAgreement = valueAgreement;
            this.NumInstallments = numInstallments.ToString() == "" ? 0 : numInstallments;
            this.Status = false;
            this.CreatedAt = DateTime.Now;
            this.UpdateAt = updatedAt;
            this.InitDateAgreement = initDateAgreement;
            this.FinalDateAgreement = finalDateAgreement;

            // verificar se as variaveis initDate e Final possuem e valor, se possuirem chamam a função setPeriodAgreement
            if (initDateAgreement.ToString() != "" && finalDateAgreement.ToString() != "")
            {
                setPeriodAgreement(initDateAgreement, finalDateAgreement);
            }
            else this.PeriodAgreement = Convert.ToDateTime("00:00:00");

            this.House = House;
            this.Tenants = new List<Tenant>();
            this.User = new User();
        }
        #endregion

        #region Get and set the periods agreement

        public DateTime GetPeriodAgreement()
        {
            return this.PeriodAgreement;
        }

        public void setPeriodAgreement(DateTime initDateAgreement, DateTime finalDateAgreement)
        {
            TimeSpan period = finalDateAgreement - initDateAgreement;
            this.PeriodAgreement = Convert.ToDateTime(period);
        }
        #endregion
    }
}
