﻿
namespace HtmlParser.Core
{
   using System.Net;
   using System.Net.Http;
   using System.Threading.Tasks;

   public class HtmlLoader
   {
      private readonly HttpClient client;
      private readonly string url;
      public HtmlLoader(ICrawlerSettings settings)
      {
         client = new HttpClient();
         url = $"{settings.CategoriesPageUrl}";
      }


      public async Task<string> GetSourceByPageId()
      {
         var currentUrl = url;
         var response = await client.GetAsync(currentUrl);

         string source = null;

         if (response != null && response.StatusCode == HttpStatusCode.OK)
         {
            source = await response.Content.ReadAsStringAsync();
         }

         return source;
      }
   }
}
