﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Laboratorio19._1.Models.WS;

namespace Laboratorio19._1.Controllers
{
    public class AccessController : ApiController
    {
        [HttpGet]
        public Reply HelloWorld()
        {
            Reply oR = new Reply();
            oR.result = 1;
            oR.message = "Mi Hello World en API";

            return oR;
        }
    }
}
