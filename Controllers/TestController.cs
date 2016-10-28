using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Collections;
 
namespace SimpleWebApi.Controllers
{
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        // GET api/files
        [HttpGet]
        public ActionResult getFiles()
        {
            string [] dirFiles = Directory.GetFiles(".");
            return Json( new { files=dirFiles } );
        }
        
        [HttpGet("{filename}/{fileextension}")]
        public ActionResult getFileInfo(string filename, string fileextension)
        {
            FileInfo fi = new FileInfo(filename+'.'+fileextension);
            return Json( new { name = filename, size=fi.Length});
        }
    }
}