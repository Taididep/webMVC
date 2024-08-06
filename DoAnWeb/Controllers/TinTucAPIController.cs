using DoAnWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoAnWeb.Views.Home
{
    public class TinTucAPIController : ApiController
    {
        DataClasses1DataContext db = new DataClasses1DataContext();


        [HttpGet]
        public List<TINTUC> GetTINTUCLists()
        {
            return db.TINTUCs.ToList();
        }

        [HttpGet]
        public TINTUC GetTINTUCs(int id)
        {
            return db.TINTUCs.FirstOrDefault(s => s.MATINTUC == id);
        }
    }
}
