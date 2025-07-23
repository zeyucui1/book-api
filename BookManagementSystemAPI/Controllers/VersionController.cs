using BookManagementSystemAPI.Settings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace BookManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private AppInfo _appInfo;
        private ILogger<VersionController> _logger;
        public VersionController(IOptions<AppInfo> appInfo, ILogger<VersionController> logger)
        {
            _appInfo = appInfo.Value;
            _logger = logger;
        }

        /// <summary>
        /// Return AppInfo from configuration
        /// </summary>
        /// <response code="200"></response>
        /// <response code="500"></response>
        /// <returns>Returns AppInfo</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AppInfo))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[Authorize]
        //更规范的接口定义
        public async Task<ActionResult<AppInfo>>  GetAppVersion() 
        {
            //int appVersion = Convert.ToInt32(_configuration["AppVersion"]);       

            _logger.LogInformation("Fetching AppInfo from appsettings.....");

            int appVersion = _appInfo.AppVersion;

            if (_appInfo.AppVersion <= 0 || _appInfo.AppName == null)
            {
                throw new System.Exception("Failed to load appsettings, value null or empty");
            }

            return Ok(_appInfo);
        }
    }
}
