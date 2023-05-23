using QazLogistic.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazLogistic.Application.Features.Account.Command.Register
{
    public class RegisterCommandResponse : QazLogResponse<RegisterCommandResponse>
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
