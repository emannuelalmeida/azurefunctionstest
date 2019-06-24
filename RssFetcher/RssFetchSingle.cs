
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace RssFetcher
{
    public static class RssFetchSingle
    {
        [FunctionName("RssFetch")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            log.Info("Search started");

            string source = req.Query["source"];
            string term = req.Query["term"];

            if (term == null) 
                return new OkObjectResult("Has to send a nice result to say it was fine.");

            List<SearchResult> results;

            if (source != null)
                results = FetchFromSingleSource(term, source);
            else
                results = FetchFromAllSources(term);

            return (ActionResult)new OkObjectResult(results);
        }

        private static List<SearchResult> FetchFromSingleSource(string term, string source)
        {

            return null;
        }

        private static List<SearchResult> FetchFromAllSources(string term)
        {

            return null;
        }
    }
}
