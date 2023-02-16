using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.IO;
using COMP1640.Models;

namespace COMP1640.Controllers
{
    public class DocumentController : Controller
    {
        private readonly ApplicationDbContext Db;
        public DocumentController(ApplicationDbContext context)
        {
            Db = context;
        }

        [HttpGet]
        public IActionResult AddFile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFile(List<IFormFile> uploadedFiles)
        {
            if (uploadedFiles.Count > 0)
            {
                foreach (var file in uploadedFiles)
                {

                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");

                    //create folder if not exist
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);


                    string fileNameWithPath = Path.Combine(path, file.FileName);

                    using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                    {
                        file.CopyTo(stream); //đoạn này add vô root 

                    }
                    Models.Document doc = new Models.Document() //đoạn này đang addd  dữ liệu vô database goodddd :)))
                    {

                        doc_content = file.FileName,
                        doc_type = "Still dont know",
                        IdeaId = 1
                    };
                    Db.Add(doc); 
                    Db.SaveChanges();

                }
                return View("AddFile");
            }

            return View("AddFile", uploadedFiles);
            /*var files = uploadedFiles.Files;

            if (files == null)
            {
                return RedirectToAction(nameof(AddFile));
            }

            foreach (var file in files)
            {
                var memoryStream = this._streamService
                    .CopyFileToMemoryStreamAsync(image);

                await this._imageService.AddImageAsync(new ImageServiceModel()
                {
                    ImageTitle = image.FileName,
                    ImageData = memoryStream.ToArray(),
                    UploaderId = userId
                });
            }

            return RedirectToAction("AddIdea");*/
        }
    }
}
