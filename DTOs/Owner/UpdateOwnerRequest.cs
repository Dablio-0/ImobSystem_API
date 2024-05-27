namespace ImobSystem_API.DTOs.Owner
{
    public record UpdateOwnerRequest(
        string name,
        string email,
        string phone,
        string cpf);
}
