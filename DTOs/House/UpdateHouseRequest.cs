namespace ImobSystem_API.DTOs.House
{
    public record UpdateHouseRequest(
        uint id,
        string address,
        uint rooms,
        string type,
        string zipCode);
}
