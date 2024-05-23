namespace ImobSystem_API.DTOs.Houses
{
    public record UpdateHouseRequest(
        uint id,
        string address,
        uint rooms,
        string type,
        string zipCode);
}
