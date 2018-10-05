using BlockChain.Datalayer.DataObject;
using BlockChain.Utility;
using Presentation.BcashPay.Controllers.Helpers;
using Presentation.BcashPay.v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.BcashPay.v2.Controllers
{
    public class HomeController : BaseController
    {
        CCoreDao db = new CCoreDao();
        GenerateData render = new GenerateData();
        public ActionResult Index()
        {
            string xmlICOInfo = render.GenerateXmlFromObject(null, new
            {
                pageNumber = 0,
                pageSize = int.MaxValue,
                sortDataField = "ID",
                sortOrder = "asc"

            }, "52", "Frontend_List");
            var tblICOInfo = db.GetContextData(xmlICOInfo);
            ICOInfo icoInfo = render.ResponseObject<ICOInfo>(tblICOInfo.Tables[0]);
            return View(icoInfo);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SetCulture(string culture)
        {
            // Validate input
            culture = CultureHelper.GetImplementedCulture(culture);

            RouteData.Values["culture"] = culture;
            Session["culture"] = culture;

            // Save culture in a cookie
            HttpCookie cookie = Request.Cookies["_culture"];
            if (cookie != null)
                cookie.Value = culture;   // update cookie value
            else
            {
                cookie = new HttpCookie("_culture");
                cookie.Value = culture;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult Statistics()
        {
            CCoreDao db = new CCoreDao();
            GenerateData Render = new GenerateData();
            //var userID = 0;
            string xmlGetUser = Render.GenerateXmlFromObject<object>(null, new
            {
                Start = 0,
                RowspPage = 0,
                TickerID = 0,
                Side = 0
            }, "61", "", 13);
            var ds = db.GetContextData(xmlGetUser);
            var data = Render.ResponseMultiObject<Statistics>(ds.Tables[0]).ToList();
            return Json(data);
        }
    }
}