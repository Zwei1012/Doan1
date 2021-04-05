using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyTinTuc.Models;

namespace QuanLyTinTuc.Controllers
{
    public class FileListHistoryController : Controller
    {
        // GET: FileListHistory
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListHistory()
        {
            return View(PostedFiles.GetTINTUCs());
        }
    }
}