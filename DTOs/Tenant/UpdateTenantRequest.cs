﻿namespace ImobSystem_API.DTOs.Tenant
{
    public record class UpdateTenantRequest(
        string name,
        string email,
        string phone,
        string cpf);
}
