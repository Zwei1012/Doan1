using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using QuanLyTinTuc.Models;

namespace QuanLyTinTuc.Controllers
{
    public class FileUploadController : Controller
    {
        //  
        // GET: /FileUpload/  
        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(News news)
        {
            using (WebTinTucEntities entity = new WebTinTucEntities())
            {
                var tintuc=new TINTUC()
                {
                    TieuDe = news.TieuDe,
                    MoTaNgan = news.MoTaNgan,
                    MaTheLoai =news.MaTheLoai,
                    MaLoaiTIn=news.MaLoaiTin,
                    NguoiDangBai=news.NguoiDangBai,
                    LinkFile = SaveToPhysicalLocation(news.LinkFile),  
                    NgayDang = DateTime.Now
                };
                entity.TINTUCs.Add(tintuc);
                entity.SaveChanges();
            }
            return View(news);
        }      
        /// Save Posted File in Physical path and return saved path to store in a database  
        /// </summary>   
        private string SaveToPhysicalLocation(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                file.SaveAs(path);
                return path;
            }
            return string.Empty;
        }
       
    }
}
