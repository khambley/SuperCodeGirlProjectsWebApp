using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SuperCodeGirlProjectsWebApp.Models
{
	public class Project
	{
		public int ProjectId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImagePath { get; set; }
		[NotMapped]
		public IFormFile ImageFile { get; set; }
		public string IconPath { get; set; }
		[NotMapped]
		public IFormFile IconFile { get; set; }
		public string BodyText { get; set; }
		public DateTime CreationDate { get; set; }
		public List<Technology> Technologies { get; set; }
	}
}
