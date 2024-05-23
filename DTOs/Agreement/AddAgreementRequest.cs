using ImobSystem_API.Models;

namespace ImobSystem_API.DTOs.Agreement
{
    public record class AddAgreementRequest
    (
        uint id,
        string owner,
        string tenant,
        string description,
        string valueAgreement,
        uint numInstallments,
        bool status,
        DateTime createdAt,
        DateTime updateAt,
        DateTime initDateAgreement,
        DateTime periodAgreement,
        DateTime finalDateAgreement,
        House House
    );
}
