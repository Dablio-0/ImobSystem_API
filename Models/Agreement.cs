using System.Collections.Immutable;
using System.Formats.Asn1;
using System.Xml;

namespace ImobSystem_API.Models
{
    public class Agreement
    {
        #region Properties
        public uint id;
        private string owner;
        private string tenant;
        private string description;
        private string valueAgreement;
        private uint numInstallments;
        private bool status;
        private DateTime createdAt;
        private DateTime updateAt;
        private DateTime initDateAgreement;
        private DateTime periodAgreement;
        private DateTime finalDateAgreement;
        #endregion

        #region Section of Relationships 
        // Agreement - House (One to One)
        private House House;

        // Agreement - Tenant (Many to Many)
        private ICollection<Tenant> Tenants = new List<Tenant>();
        #endregion

        #region Constructor
        public Agreement(string owner, string tenant, string description, string valueAgreement, uint numInstallments, DateTime updatedAt, DateTime initDateAgreement, DateTime finalDateAgreement)
        {
            this.owner = owner;
            this.tenant = tenant;
            this.description = description;
            this.valueAgreement = valueAgreement;
            this.numInstallments = numInstallments.ToString() == "" ? 0 : numInstallments;
            this.status = false;
            this.createdAt = DateTime.Now;
            this.updateAt = updatedAt;
            this.initDateAgreement = initDateAgreement;
            this.finalDateAgreement = finalDateAgreement;

            // verificar se as variaveis initDate e Final possuem e valor, se possuirem chamam a função setPeriodAgreement
            if (initDateAgreement.ToString() != "" && finalDateAgreement.ToString() != "")
            {
                setPeriodAgreement(initDateAgreement, finalDateAgreement);
            }
            else periodAgreement = Convert.ToDateTime("00:00:00");
        }
        #endregion

        #region Get & Set of Properties
        public string getOwner()
        {
            return this.owner;
        }

        public void SetOwner(string owner)
        {
            this.owner = owner;
        }

        public string getTenant()
        {
            return this.tenant;
        }

        public void setTenant(string tenant)
        {
            this.tenant = tenant;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public string getValueAgreement()
        {
            return this.valueAgreement;
        }

        public void setValueAgreement(string valueAgreement)
        {
            this.valueAgreement = valueAgreement;
        }

        public uint getNumInstallments()
        {
            return this.numInstallments;
        }

        public void setNumInstallments(uint numInstallments)
        {
            this.numInstallments = numInstallments;
        }

        public bool getStatus()
        {
            return this.status;
        }

        public void setStatus(bool status)
        {
            this.status = status;
        }
        #endregion

        #region get the date and time when the agreement was created
        public DateTime getCreatedAt()
        {
            return this.createdAt;
        }

        public DateTime getUpdateA()
        {
            return this.updateAt;
        }

        public void setUpdateA(DateTime updateAt)
        {
            this.updateAt = updateAt;
        }

        public DateTime GetInitDateAgreement()
        {
            return this.initDateAgreement;
        }

        public void setInitDateAgreement(DateTime initDateAgreement)
        {
            this.initDateAgreement = initDateAgreement;
        }

        public DateTime GetFinalDateAgreement()
        {
            return this.finalDateAgreement;
        }

        public void setFinalDateAgreement(DateTime finalDateAgreement)
        {
            this.finalDateAgreement = finalDateAgreement;
        }

        public DateTime GetPeriodAgreement()
        {
            return this.periodAgreement;
        }

        public void setPeriodAgreement(DateTime initDateAgreement, DateTime finalDateAgreement)
        {
            TimeSpan period = finalDateAgreement - initDateAgreement;
            this.periodAgreement = Convert.ToDateTime(period);
        }
        #endregion

        #region Gets & sets of Relationships 

        // Agreement - House (One to One)
        public House getHouse()
        {
            return House;
        }

        public void setHouse(House house)
        {
            House = house;
        }

        // Agreement - Tenant (Many to Many)
        public ICollection<Tenant> getTenants()
        {
            return Tenants;
        }

        public void setTenants(ICollection<Tenant> tenants)
        {
            Tenants = tenants;
        }
        #endregion
    }
}
