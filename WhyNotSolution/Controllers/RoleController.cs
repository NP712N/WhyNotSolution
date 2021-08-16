using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Repository;

namespace WhyNotSolution.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase {

        private readonly IRoleRepository RoleRepository;
        public RoleController(IRoleRepository roleRepository) {
            RoleRepository = roleRepository;
        }

        [HttpGet]
        public IActionResult GetRoles() {
            var list = RoleRepository.GetAll();
            return Ok(list);
        }
    }
}
