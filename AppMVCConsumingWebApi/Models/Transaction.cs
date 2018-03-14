using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVCConsumingWebApi.Models
{
  public class Transaction
  {
    public bool IsValid { get; set; }
    public string Message { get; set; }
    public List<Models.Product> Products { get; set; }
    public string PartialView { get; set; }    

  }
}
