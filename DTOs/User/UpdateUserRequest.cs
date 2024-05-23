namespace ImobSystem_API.DTOs.User
{
    public record UpdateUserRequest(
        string name,
        string email,
        string password,
        DateOnly age);
}
