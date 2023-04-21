using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PacSensors.Repositories;

namespace PacSensors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GP_INST_Controller : ControllerBase
    {
        private readonly IGP_INST_Repository _repository;
        public GP_INST_Controller(IGP_INST_Repository repository)
        {
            _repository = repository;
        }

    }
}
