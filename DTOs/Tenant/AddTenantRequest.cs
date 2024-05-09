namespace ImobSystem_API.DTOs.Tenant
{
    public record class AddTenantRequest
    (
        string name,
        string email,
        string phone,
        string CPF
    );
}
