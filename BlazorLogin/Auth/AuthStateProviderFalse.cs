using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorLogin.Auth
{
    public class AuthStateProviderFalse : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimo = new ClaimsIdentity();
            return await Task.FromResult(new AuthenticationState (new ClaimsPrincipal(anonimo)));
        }
    }
}
