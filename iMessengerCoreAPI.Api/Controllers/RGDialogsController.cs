using iMessengerCoreAPI.Domain.Abstractions;
using iMessengerCoreAPI.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace iMessengerCoreAPI.Api.Controllers
{
    /// <summary>
    /// RGDialogsController performs actions with RGDialogs
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class RGDialogsController : ControllerBase
    {
        private readonly ILogger<RGDialogsController> _logger;
        private readonly IRGDialogsService _rgDialogsService;

        public RGDialogsController(ILogger<RGDialogsController> logger, IRGDialogsService rgDialogsService)
        {
            _logger = logger;
            _rgDialogsService = rgDialogsService;
        }

        /// <summary>
        /// Try to find a common client's dialog
        /// </summary>
        /// <param name="clients">list of RGDialogsClients</param>
        /// <returns>Guid</returns>
        [HttpGet("TryFindCommonDialog")]
        [ProducesResponseType(typeof(Guid), StatusCodes.Status200OK)]
        public Guid TryFindDialog(List<RGDialogsClients> clients)
        {
            return _rgDialogsService.TryFindCommonDialog(clients);
        }
    }
}