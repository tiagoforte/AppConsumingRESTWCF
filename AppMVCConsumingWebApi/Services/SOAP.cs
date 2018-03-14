using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVCConsumingWebApi.Services
{
  public class SOAP
  {
    public ServiceGetProducts.Transaction GetProduct(string token)
    {

      ServiceGetProducts.GetProductRequest request = new ServiceGetProducts.GetProductRequest
      {
        token = token
      };
      ServiceGetProducts.ProductClient client = new ServiceGetProducts.ProductClient("BasicHttpBinding_IProduct");    
      var response = client.GetProduct(request);
      return response.GetProductResult;
    }

    public ServiceGetToken.Token GetToken()
    {
      ServiceGetToken.GetTokenRequest request = new ServiceGetToken.GetTokenRequest();
      ServiceGetToken.AuthClient client = new ServiceGetToken.AuthClient("BasicHttpBinding_IAuth");
      var response = client.GetToken(request);

      return response.GetTokenResult;
    }
  }
}