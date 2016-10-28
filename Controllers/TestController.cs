using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Collections;
 
namespace tinywebapi.Controllers
{
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        // GET api/files
        [HttpGet]
        public ActionResult Get()
        {
            string [] dirFiles = Directory.GetFiles(".");
            return Json( new { files=dirFiles } );
        }
 
        // GET api/files/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}