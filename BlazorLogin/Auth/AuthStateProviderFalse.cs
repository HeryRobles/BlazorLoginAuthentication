using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorLogin.Auth
{
    public class AuthStateProviderFalse : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimo = new ClaimsIdentity();
            var usuarioHery = new ClaimsIdentity(
                new List<Claim>
                {
                    new Claim("llave1", "valor1"),
                    new Claim("mugiwara", "999"),
                    new Claim(ClaimTypes.Name, "Heriberto"),
                },
                authenticationType: "prueba");
            return await Task.FromResult(new AuthenticationState (new ClaimsPrincipal(usuarioHery)));
        }
    }
}
