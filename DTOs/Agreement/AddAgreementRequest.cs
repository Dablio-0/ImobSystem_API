namespace ImobSystem_API.DTOs.Agreement
{
    public record class AddAgreementRequest
    (
        uint id,
        string Owner,
        string Tenant,
        string Description,
        string ValueAgreement,
        uint NumInstallments,
        bool Status,
        DateTime CreatedAt,
        DateTime UpdateAt,
        DateTime InitDateAgreement,
        DateTime PeriodAgreement,
        DateTime FinalDateAgreement
    );
}
