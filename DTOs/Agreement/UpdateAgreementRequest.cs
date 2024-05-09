namespace ImobSystem_API.DTOs.Agreement
{
    public record class UpdateAgreementRequest
    (
        uint id,
        string Owner,
        string Tenant,
        string Description,
        string ValueAgreement,
        uint NumInstallments,
        bool Status
    );
}
