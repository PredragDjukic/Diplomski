﻿using Diplomski.BLL.DTOs;
using Diplomski.BLL.Interfaces;
using Diplomski.BLL.Utils.Constants;
using Microsoft.AspNetCore.Mvc;

namespace Diplomski.BLL.Controllers
{
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly IUserService _service;


        public AuthController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route(Routes.Register)]
        public ActionResult Register([FromBody] UserRegisterDto dto)
        {
            string token = _service.Register(dto);

            return Ok(new { Token = token });
        }
    }
}
