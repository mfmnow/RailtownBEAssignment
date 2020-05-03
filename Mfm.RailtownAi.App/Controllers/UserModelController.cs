using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mfm.RailtownAi.App.Models;
using Mfm.RailtownAi.Domain.Contracts;
using Mfm.RailtownAi.Domain.Models;
using Mfm.RailtownAi.Domain.Models.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mfm.RailtownAi.App.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserModelController : ControllerBase
    {
        private readonly ILogger<UserModelController> _logger;
        private readonly ICloseUsersDomainService _closeUsersDomainService;

        public UserModelController(ICloseUsersDomainService closeUsersDomainService, ILogger<UserModelController> logger)
        {
            _closeUsersDomainService = closeUsersDomainService;
            _logger = logger;
        }

        [HttpGet("get-closest-users")]
        public async Task<APIRequestResult<List<UserModel>>> GetClosestUsers()
        {
            try
            {
                var list = await _closeUsersDomainService.GetClosestUsers();
                return new APIRequestResult<List<UserModel>>
                {
                    Success = true,
                    Data = list
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new APIRequestResult<List<UserModel>>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }
    }
}
