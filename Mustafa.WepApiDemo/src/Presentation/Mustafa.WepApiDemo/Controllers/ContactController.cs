﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mustafa.WepApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustafa.WepApiDemo.Controllers
{
    [Route("api/[controller]")]
    public class ContactController:Controller
    {
        [HttpGet("")]
        [Authorize(Roles = "Admin")]
        public List<ContactModel> Get()
        {
            return new List<ContactModel>
            {
                new ContactModel{Id = 1, FirstName = "Mustafa", LastName = "Şimşek"}
            };
        }
    }
}
