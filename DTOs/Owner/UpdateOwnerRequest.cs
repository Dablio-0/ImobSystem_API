namespace ImobSystem_API.DTOs.Owner
{
    public record UpdateOwnerRequest(
        uint id,
        string name,
        string email,
        string phone,
        string cpf);
}
