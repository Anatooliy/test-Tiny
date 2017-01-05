using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testTiny.Models
{
    public class TinyModel
    {       
        [AllowHtml]
        public string HtmlContent { get; set; }

        public TinyModel()
        {

        }
    }
}