using Kausar.Data.Entity;
using Kausar.Infrastructure;
using KDS.Primitives.FluentResult;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace QazLogistic.Application.Features.Account.Query.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQueryRequest, Result>
    {
        private readonly KausarDbContext _context;
        private readonly IConfiguration _configuration;
        public LoginQueryHandler(
            KausarDbContext apiDbContext, IConfiguration configuration)
        {
            _context = apiDbContext;
            _configuration = configuration;

        }
        public async Task<Result> Handle(LoginQueryRequest request, CancellationToken cancellationToken)
        {
            var user = await _context.Customers.FirstOrDefaultAsync(s => s.Email == request.loginDTO.Email, cancellationToken: cancellationToken);

            if (user == null)
            {
                return Result.Failure(new Error("", ""));
            }
            else if (!VerifyPasswordHash(request.loginDTO.Password, user.PasswordHash, user.PasswordSalt))
            {
                return Result.Failure(new Error("", ""));
            }
            else
            {
                return Result.Success(GenerateJwtToken(user));
            }
        }

        /// <summary>
        /// GenerateJWTToken
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash =
                    hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private string GenerateJwtToken(Customer user)
        {
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email),
        };
            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(100),
                    signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}

