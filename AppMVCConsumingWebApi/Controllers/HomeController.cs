using AppMVCConsumingWebApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace AppMVCConsumingWebApi.Controllers
{
  public class HomeController : Controller
  {
    public Services.REST _servicesREST { get; set; }
    public Services.SOAP _servicesSOAP { get; set; }
    public HomeController()
    {
      _servicesREST = new Services.REST();
      _servicesSOAP = new Services.SOAP();
    }
    public ActionResult Index()
    {
      return View();
    }

    public JsonResult GetProductREST(string token)
    {      

      var response = _servicesREST.GetProduct(token);
      if (response.IsSuccessStatusCode)
      {
        var products = response.Content.ReadAsAsync<List<Product>>().Result;
        var html = RenderRazorViewToString("_PartialProducts", products);
        return Json(new Models.Transaction { IsValid = true, PartialView = html }, JsonRequestBehavior.AllowGet);
      }

      return Json(new Models.Transaction { IsValid = false, Message = "Token expirado." }, JsonRequestBehavior.AllowGet);
    }

    public JsonResult GetTokenSOAP()
    {
      var token = _servicesSOAP.GetToken();
      return Json(token.Value, JsonRequestBehavior.AllowGet);
    }


    public JsonResult GetProductSOAP(string token)
    {     

      var response = _servicesSOAP.GetProduct(token);
      if (response.IsValid)
      {
        var products = new List<Models.Product>();
        foreach (var item in response.Products.ToList())
        {
          products.Add(new Product { Id = item.Id, Name = item.Name, Price = item.Price });
        }
        var html = RenderRazorViewToString("_PartialProducts", products);
        return Json(new Models.Transaction { IsValid = true, PartialView = html }, JsonRequestBehavior.AllowGet);
      }

      return Json(new Models.Transaction { IsValid = response.IsValid, Message = response.Message }, JsonRequestBehavior.AllowGet);
    }

    public string RenderRazorViewToString(string viewName, object model)
    {
      ViewData.Model = model;
      using (var sw = new StringWriter())
      {
        var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext,
                                                                 viewName);
        var viewContext = new ViewContext(ControllerContext, viewResult.View,
                                     ViewData, TempData, sw);
        viewResult.View.Render(viewContext, sw);
        viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
        return sw.GetStringBuilder().ToString();
      }
    }


  }
}