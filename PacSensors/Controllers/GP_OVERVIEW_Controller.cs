using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PacSensors.Repositories;

namespace PacSensors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GP_OVERVIEW_Controller : ControllerBase
    {
        private readonly IGP_OVERVIEW_Repository _repository;

        public GP_OVERVIEW_Controller(IGP_OVERVIEW_Repository repository)
        {
            _repository = repository;
        }
    }
}
