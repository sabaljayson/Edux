﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Edux.Data;
using Edux.Models;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Edux.Controllers
{
    [Authorize]
    public class MediasController : ControllerBase
    {

        private readonly IHostingEnvironment _hostingEnvironment;

        public MediasController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment):base(context)
        {
            _hostingEnvironment = hostingEnvironment;
            
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewBag.AssetsUrl = "/uploads/";
            base.OnActionExecuted(context);
        }
        // GET: Medias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Media.ToListAsync());
        }

        // GET: Medias/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var media = await _context.Media
                .SingleOrDefaultAsync(m => m.Id == id);
            if (media == null)
            {
                return NotFound();
            }

            return View(media);
        }

        // GET: Medias/Create
        public IActionResult Create(string element = "")
        {
            if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                ViewBag.Element = element;
                return View("ModalCreate");
            }
            var media = new Media();
            media.Year = DateTime.Now.Year;
            media.Month = DateTime.Now.Month;
            return View(media);
        }

       

        public JsonResult ModalCreate(string Title, string Description, IFormFile uploadFile)
        {
            //IFormFileCollection uploadedFiles = Request.Form.Files;
            //IFormFile uploadedFile = uploadedFiles[0];
            IFormFile file = Request.Form.Files[0];
            if (ModelState.IsValid)
            {
                var extension = "";
                if (uploadFile != null)
                {
                    extension = Path.GetExtension(uploadFile.FileName.ToLowerInvariant());
                }
                if (uploadFile != null)
                {

                    Media media = new Media();
                    media.Description = Description;
                    media.Name = uploadFile.FileName;
                    media.FileSize = (uploadFile.Length / 1024);
                    media.CreatedBy = User.Identity.Name ?? "username";
                    media.CreateDate = DateTime.Now;
                    media.UpdatedBy = User.Identity.Name ?? "username";
                    media.UpdateDate = DateTime.Now;
                    media.Year = DateTime.Now.Year;
                    media.Month = DateTime.Now.Month;
                    media.Extension = extension;

                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                    {
                        media.ContentType = "Image";
                    }
                    else if (extension == ".mp4" || extension == ".gif")
                    {
                        media.ContentType = "Video";
                    }
                    else
                    {
                        media.ContentType = "Document";
                    }

                    if (extension == ".doc"
                    || extension == ".pdf"
                    || extension == ".rtf"
                    || extension == ".docx"
                    || extension == ".jpg"
                    || extension == ".gif"
                    || extension == ".png"
                    || extension == ".mp4"
                    || extension == ".mp4"
                     )
                    {
                        string category = DateTime.Now.Month + "-" + DateTime.Now.Year;
                        string FilePath = _hostingEnvironment.WebRootPath + "/uploads/" + category + "/";
                        string dosyaismi = Path.GetFileName(uploadFile.FileName);
                        var yuklemeYeri = Path.Combine(FilePath, dosyaismi);
                        media.FilePath =  category + "/"+  dosyaismi;

                        if (!Directory.Exists(FilePath))
                        {
                            Directory.CreateDirectory(FilePath);//Eðer klasör yoksa oluþtur    
                        }
                        using (var stream = new FileStream(yuklemeYeri, FileMode.Create))
                      
                        {
                            uploadFile.CopyTo(stream);
                        }

                       

                        _context.Add(media);
                        _context.SaveChanges();

                        return Json(new { result =   media.FilePath + media.Name });

                    }
                    else
                    {
                        ModelState.AddModelError("FileName", "Dosya uzantýsý izin verilen uzantýlardan olmalýdýr.");
                    }
                }
                else { ModelState.AddModelError("FileExist", "Lütfen bir dosya seçiniz!"); }
            }
            return Json(new { result = "false" });
        }

        public IEnumerable<Media> MediaGallery(string word, int? year, int? month, string contenttype)
        {
            var mediagallery = _context.Media.Where(w => w.CreateDate.Year == year && w.CreateDate.Month == month && w.ContentType == contenttype).ToList();

            if (!string.IsNullOrEmpty(word))
            {
                mediagallery = mediagallery.Where(w => w.Description.Contains(word) || w.Name.Contains(word)).ToList();
            }
            return mediagallery;
        }


        public JsonResult ModalGallery(string word, int year, int month, string contenttype)
        {
            var mediagallery = MediaGallery(word, year, month, contenttype);
            return Json(new { result = mediagallery });
        }
        // POST: Medias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Year,Month,Extension,Name,FileName,Description,FileSize,FilePath,ContentType,ContextType,Id,CreateDate,CreatedBy,UpdateDate,UpdatedBy,AppTenantId")] Media media, IFormFile uploadFile)
        {
         
            
            if (ModelState.IsValid)
            {
                
                     media.CreatedBy = User.Identity.Name ?? "username";
                    media.CreateDate = DateTime.Now;
                    media.UpdatedBy = User.Identity.Name ?? "username";
                    media.UpdateDate = DateTime.Now;

                    _context.Add(media);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            return View(media);
        }

        // GET: Medias/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var media = await _context.Media.SingleOrDefaultAsync(m => m.Id == id);
            if (media == null)
            {
                return NotFound();
            }
            return View(media);
        }


        // POST: Medias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Name,Description,Extension,FilePath,FileSize,Year,Month,ContentType,Id,CreateDate,CreatedBy,UpdateDate,UpdatedBy,AppTenantId")] Media media)
        {
            if (id != media.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(media);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MediaExists(media.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(media);
        }
        public async Task<ActionResult> SaveUploadedFile()
        {


            bool isSavedSuccessfully = true;
            string category = "";
            string Name = "";
            var extension = "";
            var contenttype = "";
            float Filesize = 0;
            int Year = 0;
            int Month = 0;
            
            
            try
            {
                foreach (var upload in Request.Form.Files)
                {

                    //Save file content goes here
                    if (upload != null && upload.Length > 0)
                    {
                                              
                            category = DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
                            string uploadLocation = _hostingEnvironment.WebRootPath + "\\uploads\\" + category + "\\";
                            Name = Path.GetFileName(upload.FileName);
                            extension = Path.GetExtension(Name).ToLowerInvariant();
                            Filesize = ((float)upload.Length) / ((float)1024);
                            var filePath = Path.Combine(uploadLocation,Name);
                            Year = DateTime.Now.Year;
                            Month = DateTime.Now.Month;
                             

                        if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                        {
                            contenttype = "Image";
                        }
                        else if (extension == ".mp4" || extension == ".gif")
                        {
                            contenttype = "Video";
                        }
                        else if (extension == ".docx" || extension == ".rtf" || extension == ".pdf")
                        {
                            contenttype = "Document";
                        }

                      

                        if (!Directory.Exists(uploadLocation))
                            {
                                Directory.CreateDirectory(uploadLocation); //Eğer klasör yoksa oluştur    
                            }
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                await upload.CopyToAsync(stream);
                            }


                        }
                    
                    }

                }
            catch (Exception ex)
            {
                isSavedSuccessfully = false;
            }
        

            if (isSavedSuccessfully)
            {
                return Json(new { Message =  category + "/" + Name, fileName=Name , contenttype=contenttype, Extension = extension,Filesize=Filesize,Year=Year, Month = Month,success = true });
            }
            else
            {
                return Json(new { Message = "Hata oldu, dosya kaydedilemedi.", success=false });
            }
        }
        // GET: Medias/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var media = await _context.Media
                .SingleOrDefaultAsync(m => m.Id == id);
            if (media == null)
            {
                return NotFound();
            }

            return View(media);
        }

        // POST: Medias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var media = await _context.Media.SingleOrDefaultAsync(m => m.Id == id);
            _context.Media.Remove(media);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool MediaExists(string id)
        {
            return _context.Media.Any(e => e.Id == id);
        }

       

        public IActionResult CreatePopup(string element = "")
        {
            if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                ViewBag.Element = element;
                return View("ModalCreate");
            }
            return View();
        }

       
           

                   


    }
}
