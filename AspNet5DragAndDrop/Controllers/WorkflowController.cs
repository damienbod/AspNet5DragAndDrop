using System;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using AspNet5DropAndDrop.Model;

namespace Controllers
{
	[Route("api/[controller]")]
	public class WorkflowController : Controller
	{
        private List<Section> _workflow = new List<Section>
        {
                new Section
                {
                    Id = 1,
                    Description = "root",
                    Name = "root",
                    SectionType = "container",
                    AllowedTypes = new List<string>{ "container", "task"},
                },
                new Section
                {
                    Id = 2,
                    Description = "CMD grunt",
                    Name = "taskCmdgrunt",
                    SectionType = "task",
                    AllowedTypes = new List<string>{},
                },
                new Section
                {
                    Id = 3,
                    Description = "CMD bower",
                    Name = "taskCmdbower",
                    SectionType = "task",
                    AllowedTypes = new List<string>{},
                },
                new Section
                {
                    Id = 4,
                    Description = "CMD npm",
                    Name = "taskCmdNpm",
                    SectionType = "task",
                    AllowedTypes = new List<string>{},
                },
                new Section
                {
                    Id = 5,
                    Description = "workflow",
                    Name = "workflow",
                    SectionType = "container",
                    AllowedTypes = new List<string>{ "container", "task"},
                },
                new Section
                {
                    Id = 6,
                    Description = "Visual Studio build 2015",
                    Name = "taskVSBuild2015",
                    SectionType = "task",
                    AllowedTypes = new List<string>{},
                },

        };

        [HttpGet]
		[Route("")]
		public IEnumerable<Section> Get()
		{
            return _workflow;
        }

		[HttpGet]
		[Route("{id}")]
		public Section Get(long id)
		{
            return _workflow.Find(t => t.Id == id);
		}
	}
}