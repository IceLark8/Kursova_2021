using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocFinder.Data.Repositories;
using DocFinder.Data.Models;
using DocFinder.Data.Context;

namespace DocFinder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private readonly ILogger<MainController> _logger;
        public IFileDocRepository fileDocRepository;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
            this.fileDocRepository = new FileDocRepository(new DocFinderContext());
        }



        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        [HttpGet]
        public IEnumerable<FileDoc> Get()
        {
            return fileDocRepository.GetFileDocs();
            var list = new List<FileDoc>();

            list.Add(
                new FileDoc
                {
                    Name = "Name",
                    Text = "",
                    CreationDate = DateTime.Now,
                    Source = "",
                    Authtor = "",
                    Id = 1
                });

            return list;
        }
    }
}
