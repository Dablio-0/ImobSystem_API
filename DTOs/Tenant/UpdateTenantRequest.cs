namespace ImobSystem_API.DTOs.Tenant
{
    public record class UpdateTenantRequest(
        uint id,
        string name,
        string email,
        string phone,
        string cpf);
}
