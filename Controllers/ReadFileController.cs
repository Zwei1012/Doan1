using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace QuanLyTinTuc.Controllers
{
    public class ReadFileController : Controller
    {
        // GET: ReadFile
        public ActionResult ReadFile()
        {
            return View();
        }
        public ActionResult openWord()
        {
            string FileName = "tt3.docx";
            object documentFormat = 8;
            string randomName = DateTime.Now.Ticks.ToString();
            object htmlFilePath = Server.MapPath("~/Files/") + randomName + ".htm";
            object fileSavePath = Server.MapPath("~/Files/") + Path.GetFileName(FileName);
            _Application applicationclass = new Application();
            applicationclass.Documents.Open(ref fileSavePath);
            applicationclass.Visible = false;
            Document document = applicationclass.ActiveDocument;
            document.SaveAs(ref htmlFilePath, ref documentFormat);
            document.Close();
            string wordHTML = System.IO.File.ReadAllText(htmlFilePath.ToString());
            return Content(wordHTML);
        }
    }
}