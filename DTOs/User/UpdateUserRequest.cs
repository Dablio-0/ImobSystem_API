namespace ImobSystem_API.DTOs.User
{
    public record UpdateUserRequest(
        uint id,
        string name,
        string email,
        string password,
        DateOnly age);
}
