using Blazored.LocalStorage;
using Bookify.Api.Shared;
using Bookify.Domain.Users;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;
using System.Text.Json;

namespace BookifyWebAssembly.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        public async Task<RegisterResult> Register(User registerModel)
        {
            var result = await _httpClient.PostAsJsonAsync<RegisterResult>("api/v1/users/register", registerModel);
            return result;
        }
    }
}
