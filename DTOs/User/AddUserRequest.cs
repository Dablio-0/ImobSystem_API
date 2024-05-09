using ImobSystem_API.Models;

namespace ImobSystem_API.DTOs.User
{
    public record AddUserRequest(
        string name,
        string email,
        string password);
}
