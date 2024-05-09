namespace ImobSystem_API.DTOs.House
{
    public record AddHouseRequest(
        string address,
        uint rooms,
        string type,
        string zipCode);
}
