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
                    Description = "This is a custom task.",
                    Name = "Custom",
                },
                new Section
                {
                    Id = 2,
                    Description = "This task is used to execute a grunt cmd line.",
                    Name = "Cmd Grunt Task",
                },
                new Section
                {
                    Id = 3,
                    Description = "A bower task can be executed on the build server using this task.",
                    Name = "Cmd Bower Task",
                },
                new Section
                {
                    Id = 4,
                    Description = "A npm task can be executed used this task.",
                    Name = "Cmd Npm Task",
                },
                new Section
                {
                    Id = 5,
                    Description = "A custom workflow task can be excuted using this task",
                    Name = "Workflow Spec",
                },
                new Section
                {
                    Id = 6,
                    Description = "Visual Studio build 2015",
                    Name = "taskVSBuild2015",
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