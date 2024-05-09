namespace ImobSystem_API.DTOs.Owner
{
    public record class AddOwnerRequest
    (
        string name,
        string email,
        string phone,
        string CPF
    );
}
