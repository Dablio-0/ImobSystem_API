namespace ImobSystem_API.DTOs.Houses
{
    public record AddHouseRequest(
        string address,
        uint rooms,
        string type,
        string zipCode);
}
