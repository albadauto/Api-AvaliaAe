using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace api_avaliaae.Services
{
    public static class TokenService
    {
        public static string GenerateToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler(); // Instancia um objeto do tipo JwtSecurityTokenHandler, uma classe que cria e valida tokens
            var key = Encoding.ASCII.GetBytes(Settings.Secret); //Cria um key com o secret configurado
            var tokenDescriptor = new SecurityTokenDescriptor //Cria a estrutura do token
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[] //Claims são pequenas informações dentro da chave
                {
                    new Claim(ClaimTypes.Name, "jsonwebtoken_avaliaae"),
                    new Claim(ClaimTypes.Role, "main"),
                }),
                Expires = DateTime.UtcNow.AddHours(2), //Quando vai experiar
                SigningCredentials = new SigningCredentials( 
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor); //Cria o token de acordo com a descrição do token
            return tokenHandler.WriteToken(token); //Escreve o token

        }
    }
}
