using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCodeGirlProjectsWebApp.Models
{
	public class Technology
	{
		public int TechnologyId { get; set; }
		public string Name { get; set; }
		public string IconPath { get; set; }
		[NotMapped]
		public IFormFile IconFile { get; set; }
		public int ProjectId { get; set; }

	}
}
