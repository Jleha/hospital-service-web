﻿using EF.service;
using EF.service.@interface;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IRoleService roleService;
        private readonly IUserService userService;
        private readonly IAppointmentService appointmentService;

        public TestController(
            IRoleService roleService,
            IUserService userService,
            IAppointmentService appointmentService)
        {
            this.roleService = roleService;
            this.userService = userService;
            this.appointmentService = appointmentService;
        }

        [HttpGet]
        [Route("role")]
        public IActionResult GetRole()
        {
            return this.Ok(this.roleService.GetPatientRole());
        }

        [HttpGet]
        [Route("users")]
        public IActionResult GetUsers()
        {
            return this.Ok(this.userService.FindByEmail("Ressie55@yahoo.com"));
        }

        [HttpGet]
        [Route("appointments")]
        public IActionResult GetAppointments()
        {
            return this.Ok(this.appointmentService.GetAppointments());
        }
    }
}
