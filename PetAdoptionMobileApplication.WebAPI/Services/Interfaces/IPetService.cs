﻿using PetAdoptionMobileApplication.Common.DTOs;

namespace PetAdoptionMobileApplication.WebAPI.Services.Interfaces
{
    public interface IPetService
	{
		Task<APIResponse<PetListDTO[]>> GetTheMostAffordablePetsAsync(int count);
		Task<APIResponse<PetListDTO[]>> GetPopularPetsAsync(int count);
		Task<APIResponse<PetListDTO[]>> GetLeastPopularPetsAsync(int count);
		Task<APIResponse<PetListDTO[]>> GetRandomPetsAsync(int count);
		Task<APIResponse<PetListDTO[]>> GetAllPetsAsync();
		Task<APIResponse<PetInfoDTO>> GetPetInformationAsync(string petId, Guid? userId);
		Task<APIResponse<PetListDTO[]>> GetYoungestPetsAsync(int count);
		Task<APIResponse<PetListDTO[]>> GetOldestPetsAsync(int count);
		Task<APIResponse<PetListDTO[]>> GetPetsByGender(string gender);
	}
}
