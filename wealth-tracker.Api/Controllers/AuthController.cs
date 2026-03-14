using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace wealth_tracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("login")]
        public ActionResult<string> Login([FromBody] LoginRequest request)
        {
            //NOTE: Credentials are hardcoded for demo purposes only.
            //in production, validate against a database with hashed passwords
            //e.g. using BCrypt.Verify(request.Password, user.PasswordHash)
            if (request.Username != "admin" || request.Password != "admin123")
                return Unauthorized("Невірний логін або пароль");

            var token = GenerateToken(request.Username);

            return Ok(new { Token = token });
        }

        private string GenerateToken(string username)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddMinutes(double.Parse(_config["Jwt:ExpiresInMinutes"]!));

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "User")
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: expires,
                signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public record LoginRequest(string Username, string Password);
    }
}
