using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyTinTuc.Models
{
    public class PostedFiles
    {
       public static List<TINTUC> GetTINTUCs()
        {
            var ctx = new WebTinTucEntities();
            return ctx.TINTUCs.ToList();
        }

    }
}