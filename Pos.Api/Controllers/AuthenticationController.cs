using CloudDomain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.IdentityModel.Tokens;
using Pos.EfCore.Context;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;
        readonly CloudContext _context;
        public AuthenticationController(IConfiguration configuration, CloudContext context)
        {
            _config = configuration;
            _context = context;
            string[] args = { };
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Login user)
        {
            if (user is null)
            {
                return BadRequest("Invalid user request!!!");
            }

            long userId = _context.User.Where(w => w.Email == user.UserName && w.Password == user.Password && w.IsDeleted == false).Select(s => s.ID).FirstOrDefault();
            if (userId > 0)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Secret"]));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                List<Claim> claims = new List<Claim>();
                Claim claimDb = new Claim("Tenant", "17");
                Claim claimUserId = new Claim("UserId", userId.ToString());
                claims.Add(claimDb);
                claims.Add(claimUserId);

                var tokeOptions = new JwtSecurityToken(issuer: _config["JWT:ValidIssuer"], audience: _config["JWT:ValidAudience"], claims: claims, expires: DateTime.Now.AddMinutes(10), signingCredentials: signinCredentials);
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                return Ok(new JWTTokenResponse
                {
                    Token = tokenString
                });
            }
            return Unauthorized();
        }
    }
}
