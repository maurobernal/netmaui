using Android.Net;
using IdentityModel.OidcClient.Results;
using IdentityModel.OidcClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.Services;

public static class OidcClientExtensions
{
    public static Credentials ToCredentials(this LoginResult loginResult)
        => new Credentials
        {
            AccessToken = loginResult.AccessToken,
            IdentityToken = loginResult.IdentityToken,
            RefreshToken = loginResult.RefreshToken,
            AccessTokenExpiration = loginResult.AccessTokenExpiration
        };

    public static Credentials ToCredentials(this RefreshTokenResult refreshTokenResult)
        => new Credentials
        {
            AccessToken = refreshTokenResult.AccessToken,
            IdentityToken = refreshTokenResult.IdentityToken,
            RefreshToken = refreshTokenResult.RefreshToken,
            AccessTokenExpiration = refreshTokenResult.AccessTokenExpiration
        };
}
public class Credentials
{
    public string AccessToken { get; set; } = "";
    public string IdentityToken { get; set; } = "";
    public string RefreshToken { get; set; } = "";
    public DateTimeOffset AccessTokenExpiration { get; set; }
    public string Error { get; set; } = "";
    public bool IsError => !string.IsNullOrEmpty(Error);
}