using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models.DataBase;
using MyBlog.Models.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MyBlog.Controllers
{
    //[Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly BlogContext _db;
        private readonly WriteModel _model;
        private readonly IHostingEnvironment _hostingEnvironment;
        



        public PostController(BlogContext db, WriteModel model, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _model = model;
            _hostingEnvironment = hostingEnvironment;
            
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateWrite()
        {
            return View(_model);
        }
        [HttpPost]
        public IActionResult CreateWrite(WriteModel wm)
        {

            _db.Entry(wm.Write).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _db.SaveChanges();
            return RedirectToAction("CreateWrite", "Post");
        }
        [HttpPost("/Post/FileUploader")]
        [Produces("application/json")]
        public async Task<IActionResult> CreateImage(IFormFile files)
        {        
            try
            {
                if (files != null && files.Length >= 0)
                {
                    using (FileStream writerFileStream = System.IO.File.Create(_hostingEnvironment.WebRootPath + "\\uploads\\" + files.FileName))
                    {
                        await files.CopyToAsync(writerFileStream);
                        writerFileStream.Dispose();
                        Hashtable imageUrl = new Hashtable();
                        imageUrl.Add("link", "/uploads/" + files.FileName);
                        return Json(imageUrl);
                    }

                    
                }
                return Json("Hatalı Resim");
            }
            catch (ArgumentException)
            {

                return RedirectToAction("Index", "Home");
            }


        }
        
    }
}
