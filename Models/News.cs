using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyTinTuc.Models
{
    public class News
    {
        public int MaTinTuc { get; set; }
        public string TieuDe {get;set;}
        public string MoTaNgan { get; set; }
        public string MaTheLoai { get; set; }
        public string MaLoaiTin { get; set; }
        public string NguoiDangBai { get; set; }
        public HttpPostedFileBase LinkFile { get; set; }
       
    }
}