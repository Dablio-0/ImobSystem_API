using System.Collections.Immutable;
using System.Formats.Asn1;
using System.Xml;

namespace ImobSystem_API.Models
{
    public class Agreement
    {
        private uint Id;
        private string Owner;
        private string Tenant;
        private string Description;
        private string ValueAgreement;
        private uint NumInstallments;
        private string[] PaymentGuarantee;
        private DateTime CreatedAt;
        private DateTime UpdateAt;
        private DateTime InitDateAgreement;
        private DateTime PeriodAgreement;
        private DateTime FinalDateAgreement;

        // constructor
        public Agreement(string owner, string tenant, string description, string valueAgreement, uint numInstallments, DateTime updatedAt, DateTime initDateAgreement, DateTime finalDateAgreement)
        {
            Owner = owner;
            Tenant = tenant;
            Description = description;
            ValueAgreement = valueAgreement;
            NumInstallments = numInstallments.ToString() == "" ? 0 : numInstallments;
            PaymentGuarantee = new string[] { };
            CreatedAt = DateTime.Now;
            UpdateAt = updatedAt;
            InitDateAgreement = initDateAgreement;
            FinalDateAgreement = finalDateAgreement;

            // verificar se as variaveis initDate e Final possuem e valor, se possuirem chamam a função setPeriodAgreement
            if (initDateAgreement.ToString() != "" && finalDateAgreement.ToString() != "")
            {
                SetPeriodAgreement(initDateAgreement, finalDateAgreement);
            }
            else PeriodAgreement = Convert.ToDateTime("00:00:00");
        }

        public uint GetId()
        {
            return this.Id;
        }

        public void SetId(uint id)
        {
            Id = id;
        }

        public string GetOwner()
        {
            return this.Owner;
        }

        public void SetOwner(string owner)
        {
            Owner = owner;
        }

        public string GetTenant()
        {
            return this.Tenant;
        }

        public void SetTenant(string tenant)
        {
            Tenant = tenant;
        }

        public string GetDescription()
        {
            return this.Description;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public string GetValueAgreement()
        {
            return this.ValueAgreement;
        }

        public void SetValueAgreement(string valueAgreement)
        {
            ValueAgreement = valueAgreement;
        }

        public uint GetNumInstallments()
        {
            return this.NumInstallments;
        }

        public void SetNumInstallments(uint numInstallments)
        {
            NumInstallments = numInstallments;
        }

        public string[] GetPaymentGuarantee()
        {
            return this.PaymentGuarantee;
        }

        public void SetPaymentGuarantee(string[] paymentGuarantee)
        {
            PaymentGuarantee = paymentGuarantee;
        }

        // Get the date and time when the agreement was created
        public DateTime GetCreatedAt()
        {
            return this.CreatedAt;
        }

        public DateTime GetUpdateA()
        {
            return this.UpdateAt;
        }

        public void SetUpdateA(DateTime updateAt)
        {
            UpdateAt = updateAt;
        }

        public DateTime GetInitDateAgreement()
        {
            return this.InitDateAgreement;
        }

        public void SetInitDateAgreement(DateTime initDateAgreement)
        {
            InitDateAgreement = initDateAgreement;
        }

        public DateTime GetFinalDateAgreement()
        {
            return this.FinalDateAgreement;
        }

        public void SetFinalDateAgreement(DateTime finalDateAgreement)
        {
            FinalDateAgreement = finalDateAgreement;
        }

        public DateTime GetPeriodAgreement()
        {
            return this.PeriodAgreement;
        }

        public void SetPeriodAgreement(DateTime initDateAgreement, DateTime finalDateAgreement)
        {
            TimeSpan period = finalDateAgreement - initDateAgreement;
            PeriodAgreement = Convert.ToDateTime(period);
        }
    }
}
