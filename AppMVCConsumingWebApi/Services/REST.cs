using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace AppMVCConsumingWebApi.Services
{
  public class REST
  {

    public HttpResponseMessage GetProduct(string token)
    {
      using (var client = new HttpClient())
      {
        client.BaseAddress = new Uri("http://localhost:4570");
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        return client.GetAsync("v1/product").Result;
      }

    }

  }
}