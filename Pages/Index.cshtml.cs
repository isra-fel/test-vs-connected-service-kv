using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace test_vs_connected_service_kv.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private static IConfiguration _configuration;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public IndexModel(IConfiguration configuration) => _configuration = configuration;

        public void OnGet()
        {
            ViewData["Message"] = $"My key val = {_configuration["mysecret"]}";
        }
    }
}
