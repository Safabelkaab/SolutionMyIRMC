using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace SolutionMyIRMC.MVC.Models
{
    public class DocRestfulClient
    {
        private String Base_URL = "http://localhost:18080/MyIRMC-web/rest/IRMCdoc";

        public Task<String> hello()
        {
            try
            {
                var client = new HttpClient();
                
                HttpResponseMessage response = client.GetAsync(new Uri(Base_URL)).Result;

                return response.Content.ReadAsStringAsync();
            }
            catch
            {
                return null;
            }
        }
        
    }
}