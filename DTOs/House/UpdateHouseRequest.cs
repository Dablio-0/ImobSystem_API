namespace ImobSystem_API.DTOs.Houses
{
    public record UpdateHouseRequest(
        string address,
        uint rooms,
        string type,
        string zipCode);
}
