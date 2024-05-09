namespace ImobSystem_API.DTOs.Agreement
{
    public record class UpdateAgreementRequest
    (
        uint id,
        string owner,
        string tenant,
        string description,
        string valueAgreement,
        uint numInstallments,
        bool status
    );
}
