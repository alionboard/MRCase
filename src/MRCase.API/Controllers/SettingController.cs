using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using MRCase.Application.Localization;
using MRCase.Core.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MRCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : ControllerBase
    {
        private readonly IStringLocalizer<Resource> localizer;
        private readonly IMemoryCache memoryCache;


        public SettingController(IStringLocalizer<Resource> localizer, IMemoryCache memoryCache)
        {
            this.localizer = localizer;
            this.memoryCache = memoryCache;
        }

        //Get language data
        [HttpGet]
        public ActionResult<List<LangPair>> Get()
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;

            if (cultureInfo.Name == "it-IT")
            {
                const string cacheKey = "languageListIT";

                //Checking In-Memory cache for existing data
                var response = GetCacheData(cacheKey);
                return Ok(response);
            }
            else
            {
                const string cacheKey = "languageListTR";

                //Checking In-Memory cache for existing data
                var response = GetCacheData(cacheKey);                
                return Ok(response);
            }
            
        }

        //In-Memory Cache
        private List<LangPair> GetCacheData(string cacheKey)
        {
            if (!memoryCache.TryGetValue(cacheKey, out List<LangPair> response))
            {
                response = GetLanguageList();

                var cacheExpirationOptions =
                    new MemoryCacheEntryOptions
                    {
                        AbsoluteExpiration = DateTime.Now.AddMilliseconds(10),
                        Priority = CacheItemPriority.Normal
                    };
                memoryCache.Set(cacheKey, response, cacheExpirationOptions);
            }
            return response;
        }

        //Get Language data from resx files
        private List<LangPair> GetLanguageList()
        {
            List<LangPair> list = new List<LangPair>();

            var resourceSet = localizer.GetAllStrings().Select(x => x.Name);
            foreach (var item in resourceSet)
                list.Add(new LangPair { Key = item, Value = localizer[item].Value });

            return list;
        }
    }
}
