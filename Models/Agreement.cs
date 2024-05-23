using System.Collections.Immutable;
using System.Formats.Asn1;
using System.Xml;

namespace ImobSystem_API.Models
{
    public class Agreement
    {
        #region Properties
        public uint id;
        public string owner;
        public string tenant;
        public string description;
        public string valueAgreement;
        public uint numInstallments;
        public bool status;
        public DateTime createdAt;
        public DateTime updateAt;
        public DateTime initDateAgreement;
        public DateTime periodAgreement;
        public DateTime finalDateAgreement;
        #endregion

        #region Section of Relationships 
        // Agreement - House (One to One)
        public House House;

        // Agreement - Tenant (Many to Many)
        public ICollection<Tenant> Tenants;
        #endregion

        #region Constructors
        public Agreement()
        {
            this.id = 0;
            this.owner = this.tenant = this.description = this.valueAgreement = "";
            this.numInstallments = 0;
            this.status = false;
            this.createdAt = DateTime.Now;
            this.updateAt = DateTime.Now;
            this.initDateAgreement = Convert.ToDateTime("00:00:00");
            this.finalDateAgreement = Convert.ToDateTime("00:00:00");
            this.periodAgreement = Convert.ToDateTime("00:00:00");
            this.House = new House();
            this.Tenants = new List<Tenant>();
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

            this.House = House;
            this.Tenants = new List<Tenant>();
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

        #region Get the date and time when the agreement was created
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
    }
}
